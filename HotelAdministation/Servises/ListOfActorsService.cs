using HotelAdministation.Core.AppContext;
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
    public class ListOfActorsService : BaseEntityService<ListOfActorsViewModel, ListOfActors>
    {
        public override ListOfActors ToModel(ListOfActorsViewModel model)
        {
            return new ListOfActors
            {
                Id = model.Id,
                Film = model.Film.Id,
                Actor = model.Actor.Id
            };
        }

        public override ListOfActorsViewModel ToView(ListOfActors model)
        {
            var listOfActorsFilmService = AppGlobalContext.Current.Resolve<FilmService>();
            var listOfActorsActorService = AppGlobalContext.Current.Resolve<ActorService>();
            return new ListOfActorsViewModel
            {
                Id = model.Id,
                Film = listOfActorsFilmService.GetById(model.Film),
                Actor = listOfActorsActorService.GetById(model.Actor)
            };
        }
    }
}
