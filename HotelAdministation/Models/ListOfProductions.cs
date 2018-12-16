using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class ListOfProductions
    {
        public long Id { get; set; }
        public long Film { get; set; }
        public long Genre { get; set; }

        public Film FilmNavigation { get; set; }
        public Production GenreNavigation { get; set; }
    }
}