using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class ListOfActors
    {
        public long Id { get; set; }
        public long Film { get; set; }
        public long Actor { get; set; }

        public Actor ActorNavigation { get; set; }
        public Film FilmNavigation { get; set; }
    }
}