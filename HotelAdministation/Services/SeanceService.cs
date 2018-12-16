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
    public class SeanceService : BaseEntityService<SeanceViewModel, Seance>, IService
    {
        public override Seance ToModel(SeanceViewModel model)
        {
            return new Seance
            {
                Id = model.Id,
                Film = model.Film.Id,
                Hall = model.Hall.Id,
                Date = model.Date
            };
        }

        public override SeanceViewModel ToView(Seance model)
        {
            var seanceFilmService = AppGlobalContext.Current.Resolve<FilmService>();
            var seanceHallService = AppGlobalContext.Current.Resolve<HallService>();
            return new SeanceViewModel
            {
                Id = model.Id,
                Film = seanceFilmService.GetById(model.Film),
                Hall = seanceHallService.GetById(model.Hall)
            };
        }
    }
}