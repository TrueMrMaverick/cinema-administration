using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Cinema
    {
        public Cinema()
        {
            HallList = new HashSet<HallList>();
            ListOfAreas = new HashSet<ListOfAreas>();
            ListOfCinemaCategories = new HashSet<ListOfCinemaCategories>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public long Status { get; set; }

        public CinemaStatus StatusNavigation { get; set; }
        public ICollection<HallList> HallList { get; set; }
        public ICollection<ListOfAreas> ListOfAreas { get; set; }
        public ICollection<ListOfCinemaCategories> ListOfCinemaCategories { get; set; }
    }
}