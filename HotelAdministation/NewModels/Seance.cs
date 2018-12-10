using System;
using System.Collections.Generic;

namespace HotelAdministation.NewModels
{
    public partial class Seance
    {
        public long Id { get; set; }
        public long Hall { get; set; }
        public long Film { get; set; }
        public DateTime Date { get; set; }

        public Film FilmNavigation { get; set; }
        public Hall HallNavigation { get; set; }
    }
}
