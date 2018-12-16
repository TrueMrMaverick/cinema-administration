using System;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Services
{
    public class ActorService : BaseEntityService<ActorViewModel, Actor>
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