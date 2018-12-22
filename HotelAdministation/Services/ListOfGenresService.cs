using HotelAdministation.Core.AppContext;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace HotelAdministation.Services
{
    public class ListOfGenresService: BaseEntityService<ListOfGenersViewModel, ListOfGenres>
    {
        public override ListOfGenres ToModel(ListOfGenersViewModel model)
        {
            return new ListOfGenres
            {
                Id = model.Id,
                Film = model.Film.Id,
                Genre = model.Genre.Id
            };
        }

        public override ListOfGenersViewModel ToView(ListOfGenres model)
        {
            var genreService = AppGlobalContext.Current.Resolve<GenreService>();
            var filmService = AppGlobalContext.Current.Resolve<FilmService>();
            
            return new ListOfGenersViewModel
            {
                Id = model.Id,
                Film = filmService.GetById(model.Film),
                Genre = genreService.GetById(model.Genre)
            };
        }

        public List<ListOfGenersViewModel> GetByFilmId(long filmId)
        {
            var viewModelList = new List<ListOfGenersViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }
            return viewModelList.Where(item => item.Film.Id == filmId).ToList();
        }

        public ListOfGenersViewModel GetByCombination(long filmId, long genreId)
        {
            var viewModelList = new List<ListOfGenersViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }
            return viewModelList.Find(item => item.Film.Id == filmId && item.Genre.Id == genreId);
        }
    }
}