using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.Models;
using HotelAdministation.Core.AppContext;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Services
{
    public class ListOfDirectorsService : BaseEntityService<ListOfDirectorsViewModel, ListOfDirectors>, IService
    {
        public override ListOfDirectors ToModel(ListOfDirectorsViewModel model)
        {
            return new ListOfDirectors
            {
                Id = model.Id,
                Film = model.Film.Id,
                Director = model.Director.Id
            };
        }

        public override ListOfDirectorsViewModel ToView(ListOfDirectors model)
        {
            var listOfDirectorsFilmService = AppGlobalContext.Current.Resolve<FilmService>();
            var listOfDirectorsDirectorService = AppGlobalContext.Current.Resolve<DirectorService>();
            return new ListOfDirectorsViewModel
            {
                Id = model.Id,
                Film = listOfDirectorsFilmService.GetById(model.Film),
                Director = listOfDirectorsDirectorService.GetById(model.Director)
            };
        }

        public List<ListOfDirectorsViewModel> GetByFilmId(long filmId)
        {
            var viewModelList = new List<ListOfDirectorsViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }

            return viewModelList.Where(item => item.Film.Id == filmId).ToList();
        }

        public ListOfDirectorsViewModel GetByCombination(long filmId, long directorId)
        {
            var viewModelList = new List<ListOfDirectorsViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }

            return viewModelList.Find(item => item.Film.Id == filmId && item.Director.Id == directorId);
        }
    }
}