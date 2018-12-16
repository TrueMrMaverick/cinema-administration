using HotelAdministation.Core.AppContext;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;

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
    }
}