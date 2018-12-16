using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class ListOfAreas
    {
        public long Id { get; set; }
        public long Cinema { get; set; }
        public long Area { get; set; }

        public Area AreaNavigation { get; set; }
        public Cinema CinemaNavigation { get; set; }
    }
}