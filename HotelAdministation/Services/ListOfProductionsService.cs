using HotelAdministation.Core.AppContext;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;
using System.Collections.Generic;
using System.Linq;

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
                Genre = model.Production.Id
            };
        }

        public override ListOfProductionsViewModel ToView(ListOfProductions model)
        {
            var genreService = AppGlobalContext.Current.Resolve<ProductionService>();
            var filmService = AppGlobalContext.Current.Resolve<FilmService>();
            
            return new ListOfProductionsViewModel
            {
                Id = model.Id,
                Film = filmService.GetById(model.Film),
                Production = genreService.GetById(model.Genre)
            };
        }

        public List<ListOfProductionsViewModel> GetByFilmId(long filmId)
        {
            var viewModelList = new List<ListOfProductionsViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }

            return viewModelList.Where(item => item.Film.Id == filmId).ToList();
        }

        public ListOfProductionsViewModel GetByCombinaton(long filmId, long id)
        {
            var viewModelList = new List<ListOfProductionsViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }

            return viewModelList.Find(item => item.Film.Id == filmId && item.Production.Id == id);
        }
    }
}