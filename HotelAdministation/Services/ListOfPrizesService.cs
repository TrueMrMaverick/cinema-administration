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

        public List<ListOfPrizesViewModel> GetByFilmId(long filmId)
        {
            var viewModelList = new List<ListOfPrizesViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }

            return viewModelList.Where(item => !(item.Film is null) && item.Film.Id == filmId).ToList();
        }

        public ListOfPrizesViewModel GetByCombination(long filmId, long id)
        {
            var viewModelList = new List<ListOfPrizesViewModel>();
            foreach (var item in GetModelsFromContext().ToList())
            {
                viewModelList.Add(ToView(item));
            }

            return viewModelList.Find(item => item.Film.Id == filmId && item.Prize.Id == id);
        }
    }
}