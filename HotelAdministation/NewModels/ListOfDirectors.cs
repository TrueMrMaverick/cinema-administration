using System;
using System.Collections.Generic;

namespace HotelAdministation.NewModels
{
    public partial class ListOfDirectors
    {
        public long Id { get; set; }
        public long Film { get; set; }
        public long Director { get; set; }

        public Director DirectorNavigation { get; set; }
        public Film FilmNavigation { get; set; }
    }
}
