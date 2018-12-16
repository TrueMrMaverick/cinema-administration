using HotelAdministation.Core.AppContext;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Services
{
    public class ListOfProductionsService: BaseEntityService<ListOfProductionsViewModel, ListOfProductions>
    {
        public override ListOfProductions ToModel(ListOfProductionsViewModel model)
        {
            return new ListOfProductions
            {
                Id = model.Id,
                Film = model.Film.Id,
                Genre = model.Genre.Id
            };
        }

        public override ListOfProductionsViewModel ToView(ListOfProductions model)
        {
            var genreService = AppGlobalContext.Current.Resolve<GenreService>();
            var filmService = AppGlobalContext.Current.Resolve<FilmService>();
            
            return new ListOfProductionsViewModel
            {
                Id = model.Id,
                Film = filmService.GetById(model.Film),
                Genre = genreService.GetById(model.Genre)
            };
        }
    }
}