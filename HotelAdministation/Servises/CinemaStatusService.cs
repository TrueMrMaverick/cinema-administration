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
    public class CinemaStatusService : BaseEntityService<CinemaStatusViewModel, CinemaStatus>, IService
    {
        public override CinemaStatus ToModel(CinemaStatusViewModel model)
        {
            return new CinemaStatus
            {
                Id = model.Id,
                Status = model.Status
            };
        }

        public override CinemaStatusViewModel ToView(CinemaStatus model)
        {
            return new CinemaStatusViewModel
            {
                Id = model.Id,
                Status = model.Status
            };
        }
    }
}
