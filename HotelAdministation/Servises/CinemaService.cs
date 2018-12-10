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
    public class CinemaService : BaseEntityService<CinemaViewModel, Cinema>
    {
        public override Cinema ToModel(CinemaViewModel model)
        {
            return new Cinema
            {
                Id = model.Id,
                Name = model.Name,
                Area = model.Area,
                Status = model.Status.Id
            };
        }

        public override CinemaViewModel ToView(Cinema model)
        {
            var cinemaStatusService = AppGlobalContext.Current.Resolve<CinemaStatusService>();
            return new CinemaViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Area = model.Area,
                Status = cinemaStatusService.GetById(model.Status)
            };
        }
    }
}
