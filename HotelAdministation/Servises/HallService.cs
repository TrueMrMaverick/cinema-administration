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
    public class HallService : BaseEntityService<HallViewModel, Hall>, IService
    {
        public override Hall ToModel(HallViewModel model)
        {
            return new Hall
            {
                Id = model.Id,
                Number = model.Number,
                Capacity = model.Capacity,
                TicketsLeft = model.TicketsLeft

    };

        }

        public override HallViewModel ToView(Hall model)
        {
            return new HallViewModel
            {
                Id = model.Id,
                Number = model.Number,
                Capacity = model.Capacity,
                TicketsLeft = model.TicketsLeft
            };
        }
    }
}
