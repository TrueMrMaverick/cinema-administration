using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class CinemaCategory
    {
        public CinemaCategory()
        {
            ListOfCinemaCategories = new HashSet<ListOfCinemaCategories>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ListOfCinemaCategories> ListOfCinemaCategories { get; set; }
    }
}