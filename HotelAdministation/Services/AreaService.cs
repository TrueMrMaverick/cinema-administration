﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Services
{
    public class AreaService : BaseEntityService<AreaViewModel, Area>
    {
        public override Area ToModel(AreaViewModel model)
        {
            return new Area
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public override AreaViewModel ToView(Area model)
        {
            return new AreaViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}