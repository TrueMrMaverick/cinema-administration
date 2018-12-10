using HotelAdministation.Core.AppContext;
using HotelAdministation.NewModels;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.Servises
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
    }
}
