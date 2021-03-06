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
    public class ProductionService : BaseEntityService<ProductionViewModel, Production>, IService
    {
        public override Production ToModel(ProductionViewModel model)
        {
            return new Production
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public override ProductionViewModel ToView(Production model)
        {
            return new ProductionViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}