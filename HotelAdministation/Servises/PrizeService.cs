﻿using HotelAdministation.NewModels;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.Servises
{
    public class PrizeService : BaseEntityService<PrizeViewModel, Prize>, IService
    {
        public override Prize ToModel(PrizeViewModel model)
        {
            return new Prize
            {
                Id = model.Id,
                Name = model.Name
            };

        }

        public override PrizeViewModel ToView(Prize model)
        {
            return new PrizeViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
