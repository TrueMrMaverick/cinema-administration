using System;
using System.Collections.Generic;

namespace HotelAdministation.NewModels
{
    public partial class HallList
    {
        public long Id { get; set; }
        public long Cinema { get; set; }
        public long Hall { get; set; }

        public Cinema CinemaNavigation { get; set; }
        public Hall HallNavigation { get; set; }
    }
}
