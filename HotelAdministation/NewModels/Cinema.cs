using System;
using System.Collections.Generic;

namespace HotelAdministation.NewModels
{
    public partial class Cinema
    {
        public Cinema()
        {
            HallList = new HashSet<HallList>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public long Status { get; set; }

        public CinemaStatus StatusNavigation { get; set; }
        public ICollection<HallList> HallList { get; set; }
    }
}
