﻿using System;
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
    public class HallListService : BaseEntityService<HallListViewModel, HallList>, IService
    {
        public override HallList ToModel(HallListViewModel model)
        {
            return new HallList
            {
                Id = model.Id,
                Cinema = model.Cinema.Id,
                Hall = model.Hall.Id
            };
        }

        public override HallListViewModel ToView(HallList model)
        {
            var hallListCinemaService = AppGlobalContext.Current.Resolve<CinemaService>();
            var hallListHallService = AppGlobalContext.Current.Resolve<HallService>();
            return new HallListViewModel
            {
                Id = model.Id,
                Cinema = hallListCinemaService.GetById(model.Cinema),
                Hall = hallListHallService.GetById(model.Hall)
            };
        }
    }
}