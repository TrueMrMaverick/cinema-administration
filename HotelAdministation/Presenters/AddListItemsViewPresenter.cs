using HotelAdministation.Views;
using HotelAdministation.Core.AppContext;
using HotelAdministation.ViewModels.Base;
using System.Collections.Generic;
using HotelAdministation.Presenters.Enum;
using System;
using static HotelAdministation.Presenters.AddDirectorViewPresenter;
using System.Reflection;
using System.Data;

namespace HotelAdministation.Presenters
{
    public class AddListItemsViewPresenter : AbstractPresenter<AddListItemsView, AddListItemsViewPresenter>
    {
        class ListBoxItem
        {
            public string Name { get; set; }
            public object Value { get; set; }
        }

        private FilmInfo info;
        List<object> initialSelectedItems;

        public delegate void FilmInfoHandler(FilmInfo info, List<object> items);
        public event FilmInfoHandler Selected;

        public override void InitializePresenter()
        {
            CreateView();
            ShowView();
        }

        public void InitializePresenter(FilmInfo info, List<object> initialSelectedItems)
        {
            this.info = info;
            this.initialSelectedItems = initialSelectedItems is null ? new List<object>() : initialSelectedItems;
            InitializePresenter();
        }

        public override void ShowView()
        {
            DisplayData();
            View.ActivateView();
        }

        private void DisplayData()
        {

            var checkedListBox = View.checkedListBox;
            checkedListBox.Items.Clear();
            checkedListBox.DisplayMember = "Name";
            checkedListBox.ValueMember = "Id";

            object infoService = AppGlobalContext.Current.Resolve(FilmInfoUtilGetter.GetServiceType(info));
            object items = infoService.GetType().GetMethod("GetList").Invoke(infoService, null);
            object itemsEnumerator = items.GetType().GetMethod("GetEnumerator").Invoke(items, null);


            while ((bool)itemsEnumerator.GetType().GetMethod("MoveNext").Invoke(itemsEnumerator, null))
            {
                var item = itemsEnumerator.GetType().GetProperty("Current").GetValue(itemsEnumerator, null);
                var baseViewModelType = FilmInfoUtilGetter.GetBaseViewModelType(info);

                if (baseViewModelType.Equals(typeof(BaseStaffViewModel)))
                {
                    AddToStaff((BaseStaffViewModel)item);
                } else if (baseViewModelType.Equals(typeof(BaseMetaViewModel)))
                {
                    AddToMeta((BaseMetaViewModel)item);
                }
            }
        }

        private void AddToStaff(BaseStaffViewModel model)
        {
            var item = new ListBoxItem
            {
                Name = string.Format("{0} {1}", model.FirstName, model.LastName),
                Value = model
            };

            View.checkedListBox.Items.Add(item, initialSelectedItems.Contains(model));
        }

        private void AddToMeta(BaseMetaViewModel model)
        {
            var item = new ListBoxItem
            {
                Name = model.Name,
                Value = model
            };

            View.checkedListBox.Items.Add(item, initialSelectedItems.Contains(model));
        }

        public void InitializeAddView()
        {
            Type presenterType = FilmInfoUtilGetter.GetAddViewPresenterType(info);
            var addStaffPresenter = AppGlobalContext.Current.Resolve(presenterType);

            presenterType
                .GetMethod("InitializePresenter")
                .Invoke(addStaffPresenter, null);

            EventInfo eventInfo = presenterType.GetEvent("Added");
            var baseViewModelType = FilmInfoUtilGetter.GetBaseViewModelType(info);
            string handlerMethodName = null;

            if (baseViewModelType.Equals(typeof(BaseStaffViewModel)))
            {
                handlerMethodName = "AddToStaff";
            } else if (baseViewModelType.Equals(typeof(BaseMetaViewModel)))
            {
                handlerMethodName = "AddToMeta";
            }

            Delegate handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, handlerMethodName);
            eventInfo.AddEventHandler(addStaffPresenter, handler);
        }

        private void UpdateData(FilmInfo info, BaseStaffViewModel viewModel)
        {
            View.checkedListBox.Items.Add(
                new ListBoxItem
                {
                    Name = string.Format("{0} {1}", viewModel.FirstName, viewModel.LastName),
                    Value = viewModel.Id
                });
        }

        public void Select()
        {
            var itemsToSelect = new List<object>();
            var selectedItems = View.checkedListBox.CheckedItems;

            foreach (object item in selectedItems)
            {
                object value = ((ListBoxItem)item).Value;
                itemsToSelect.Add(value);
            }

            Selected(info, itemsToSelect);
        }
    }
}