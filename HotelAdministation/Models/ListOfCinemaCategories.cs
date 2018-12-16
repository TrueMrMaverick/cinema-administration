using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class ListOfCinemaCategories
    {
        public long Id { get; set; }
        public long Cinema { get; set; }
        public long CinemaCategory { get; set; }

        public CinemaCategory CinemaCategoryNavigation { get; set; }
        public Cinema CinemaNavigation { get; set; }
    }
}