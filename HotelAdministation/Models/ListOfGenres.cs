using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class ListOfGenres
    {
        public long Id { get; set; }
        public long Film { get; set; }
        public long Genre { get; set; }

        public Film FilmNavigation { get; set; }
        public Genre GenreNavigation { get; set; }
    }
}