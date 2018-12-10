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
    public class CinemaCategoryService : BaseEntityService<CinemaCategoryViewModel, CinemaCategory>, IService
    {
        public override CinemaCategory ToModel(CinemaCategoryViewModel model)
        {
            return new CinemaCategory
            {
                Id = model.Id,
                Name = model.Name
            };
           
    }

        public override CinemaCategoryViewModel ToView(CinemaCategory model)
        {
            return new CinemaCategoryViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
