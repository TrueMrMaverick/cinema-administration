using System;
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
    public class ListOfOperatorsService : BaseEntityService<ListOfOperatorsViewModel, ListOfOperators>
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

        public List<ListOfOperatorsViewModel> GetByFilmId(long filmId)
        {
            var viewModelList = new List<ListOfOperatorsViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }

            return viewModelList.Where(item => item.Film.Id == filmId).ToList();
        }

        public ListOfOperatorsViewModel GetByCombination(long filmId, long id)
        {
            var viewModelList = new List<ListOfOperatorsViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }

            return viewModelList.Find(item => item.Film.Id == filmId && item.Operator.Id == id);
        }
    }
}