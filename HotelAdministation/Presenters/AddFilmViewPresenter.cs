using HotelAdministation.Core.AppContext;
using HotelAdministation.Services;
using HotelAdministation.Views;
using HotelAdministation.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using HotelAdministation.Presenters.Enum;
using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.Presenters
{
    public class AddFilmViewPresenter: AbstractPresenter<AddFilmView, AddFilmViewPresenter>
    {
        FilmService filmService = AppGlobalContext.Current.Resolve<FilmService>();
        FilmViewModel filmViewModel;

        private Dictionary<FilmInfo, List<object>> initialItems = new Dictionary<FilmInfo, List<object>>();
        private Dictionary<FilmInfo, List<object>> itemsToDelete = new Dictionary<FilmInfo, List<object>>();
        private Dictionary<FilmInfo, List<object>> itemsToSave = new Dictionary<FilmInfo, List<object>>();

        public delegate void FilmHandler();
        public event FilmHandler Added;

        public override void InitializePresenter()
        {
            CreateView();
            ShowView();
        }

        public void InitializePresenter(FilmViewModel source, Dictionary<FilmInfo, List<object>> initialItems)
        {
            if (initialItems is null || source is null)
            {
                Dispose();
                throw new ArgumentException("Arguments must not be null");
            }

            this.initialItems = initialItems;
            InitializePresenter();

            filmViewModel = source;
            View.filmName.Text = source.Name;
            View.durationTimePicker.Value = new DateTime(2000, 12, 12, source.Duration.Hours, source.Duration.Minutes, source.Duration.Seconds);
            View.rentalPrice.Text = source.RentalPrice.ToString();
        }

        public override void ShowView()
        {
            View.ActivateView();
        }

        public void SaveFilm(string name, TimeSpan duration, string image, int rentalPrice)
        {
            if (filmViewModel is null)
            {
                filmViewModel = new FilmViewModel();
            }

            filmViewModel.Name = name;
            filmViewModel.Duration = duration;
            filmViewModel.Image = image;
            filmViewModel.RentalPrice = rentalPrice;

            FilmViewModel savedFilm = null;

            if (filmViewModel.Id == 0)
            {
                savedFilm = filmService.SaveItem(filmViewModel);
            } else
            {
                savedFilm = filmService.UpdateItem(filmViewModel);
            }

            foreach (var item in itemsToSave)
            {
                List<BaseViewModel> listViewModels = item.Value.Select(x => FilmInfoUtilGetter.CreateListViewModel(item.Key, savedFilm, x)).ToList();

                Type serviceType = FilmInfoUtilGetter.GetListServiceType(item.Key);
                object service = AppGlobalContext.Current.Resolve(serviceType);

                foreach (var model in listViewModels)
                {
                    serviceType.GetMethod("SaveItem").Invoke(service, new object[] { model });
                }
            }

            foreach (var item in itemsToDelete)
            {
                var listServiceType = FilmInfoUtilGetter.GetListServiceType(item.Key);
                object listService = AppGlobalContext.Current.Resolve(listServiceType);

                List<BaseViewModel> listViewModels = new List<BaseViewModel>();

                foreach (BaseViewModel value in item.Value)
                {
                    var listViewModel = listServiceType.GetMethod("GetByCombination").Invoke(listService, new object[] { savedFilm.Id, value.Id });
                    listViewModels.Add((BaseViewModel)listViewModel);
                }

                foreach (var model in listViewModels)
                {
                    listServiceType.GetMethod("RemoveItem").Invoke(listService, new object[] { model });
                }
            }

            Added();
        }

        public void InitializeAddListItemsView(FilmInfo info)
        {
            var addListItemsPresenter = AppGlobalContext.Current.Resolve<AddListItemsViewPresenter>();

            bool inItemsToSave = itemsToSave.ContainsKey(info);
            bool inInitialItems = initialItems.ContainsKey(info);
            bool inItemsToDelete = itemsToDelete.ContainsKey(info);

            List<object> selectedItems = inItemsToSave ? itemsToSave[info] : new List<object>();

            List<object> selectedInitialItems = inInitialItems && inItemsToDelete ? initialItems[info].Except(itemsToDelete[info]).ToList() : initialItems[info];

            selectedItems = inInitialItems ? selectedItems.Concat(selectedInitialItems).ToList() : selectedItems;

            addListItemsPresenter.InitializePresenter(info, selectedItems);
            addListItemsPresenter.Selected += UpdateFilmInfo;
        }

        private void UpdateFilmInfo(FilmInfo info, List<object> items)
        {
            bool inInitialItems = initialItems.ContainsKey(info);
            bool inItemsToSave = itemsToSave.ContainsKey(info);
            bool inItemsToDelete = itemsToDelete.ContainsKey(info);

            List<object> newItemsToDelete = inInitialItems ? initialItems[info].Except(items).ToList() : null;
            List<object> newItemsToSave = inInitialItems ? items.Except(initialItems[info]).ToList() : items;
            
            if (inItemsToSave)
            {
                itemsToSave[info] = newItemsToSave;
            } else
            {
                itemsToSave.Add(info, newItemsToSave);
            }

            if (inItemsToDelete)
            {
                itemsToDelete[info] = newItemsToDelete;
            } else
            {
                itemsToDelete.Add(info, newItemsToDelete);
            }
        }

    }
}