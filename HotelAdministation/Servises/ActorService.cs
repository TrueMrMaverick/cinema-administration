using HotelAdministation.NewModels;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;
using System;

namespace HotelAdministation.Servises
{
    public class ActorService : BaseEntityService<ActorViewModel, Actor>, IService
    {

        public override Actor ToModel(ActorViewModel model)
        {
            return new Actor
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
        }

        public override ActorViewModel ToView(Actor model)
        {
            return new ActorViewModel
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
        }
    }
}
