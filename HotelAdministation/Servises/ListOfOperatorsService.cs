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
    public class ListOfOperatorsService : BaseEntityService<ListOfOperatorsViewModel, ListOfOperators>, IService
    {
        public override ListOfOperators ToModel(ListOfOperatorsViewModel model)
        {
            return new ListOfOperators
            {
                Id = model.Id,
                Film = model.Film.Id,
                Operator = model.Operator.Id
            };
        }

        public override ListOfOperatorsViewModel ToView(ListOfOperators model)
        {
            var listOfOperatorsFilmService = AppGlobalContext.Current.Resolve<FilmService>();
            var listOfOperatorsOperatorService = AppGlobalContext.Current.Resolve<OperatorService>();
            return new ListOfOperatorsViewModel
            {
                Id = model.Id,
                Film = listOfOperatorsFilmService.GetById(model.Film),
                Operator = listOfOperatorsOperatorService.GetById(model.Operator)
            };
        }
    }
}
}
