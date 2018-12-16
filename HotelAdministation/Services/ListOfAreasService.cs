using HotelAdministation.Core.AppContext;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Services
{
    public class ListOfAreasService: BaseEntityService<ListOfAreasViewModel, ListOfAreas>
    {
        public override ListOfAreas ToModel(ListOfAreasViewModel model)
        {
            return new ListOfAreas
            {
                Id = model.Id,
                Area = model.Area.Id,
                Cinema = model.Cinema.Id
            };
        }

        public override ListOfAreasViewModel ToView(ListOfAreas model)
        {
            var cinemaService = AppGlobalContext.Current.Resolve<CinemaService>();
            var areaService = AppGlobalContext.Current.Resolve<AreaService>();

            return new ListOfAreasViewModel
            {
                Id = model.Id,
                Area = areaService.GetById(model.Id),
                Cinema = cinemaService.GetById(model.Id)
            };
        }
    }
}