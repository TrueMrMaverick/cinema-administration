﻿using HotelAdministation.Core.AppContext;
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
    public class ListOfPrizesService : BaseEntityService<ListOfPrizesViewModel, ListOfPrizes>, IService
    {
        public override ListOfPrizes ToModel(ListOfPrizesViewModel model)
        {
            return new ListOfPrizes
            {
                Id = model.Id,
                Film = model.Film.Id,
                Prize = model.Prize.Id
            };
        }

        public override ListOfPrizesViewModel ToView(ListOfPrizes model)
        {
            var listOfPrizesFilmService = AppGlobalContext.Current.Resolve<FilmService>();
            var listOfPrizesPrizeService = AppGlobalContext.Current.Resolve<PrizeService>();
            return new ListOfPrizesViewModel
            {
                Id = model.Id,
                Film = listOfPrizesFilmService.GetById(model.Film),
                Prize = listOfPrizesPrizeService.GetById(model.Prize)
            };
        }
    }
}
