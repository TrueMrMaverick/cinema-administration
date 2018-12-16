using HotelAdministation.Core.AppContext;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Services
{
    public class ListOfCinemaCategoriesService: BaseEntityService<ListOfCinemaCategoriesViewModel, ListOfCinemaCategories>
    {
        public override ListOfCinemaCategories ToModel(ListOfCinemaCategoriesViewModel model)
        {
            return new ListOfCinemaCategories
            {
                Id = model.Id,
                Cinema = model.Cinema.Id,
                CinemaCategory = model.CinemaCategory.Id
            };
        }

        public override ListOfCinemaCategoriesViewModel ToView(ListOfCinemaCategories model)
        {
            var cinemaService = AppGlobalContext.Current.Resolve<CinemaService>();
            var cinemaCategoryService = AppGlobalContext.Current.Resolve<CinemaCategoryService>();
            return new ListOfCinemaCategoriesViewModel
            {
                Id = model.Id,
                Cinema = cinemaService.GetById(model.Id),
                CinemaCategory = cinemaCategoryService.GetById(model.Id)
            };
        }
    }
}