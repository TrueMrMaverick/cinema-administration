using System;
using System.Collections.Generic;

namespace HotelAdministation.NewModels
{
    public partial class CinemaStatus
    {
        public CinemaStatus()
        {
            Cinema = new HashSet<Cinema>();
        }

        public long Id { get; set; }
        public string Status { get; set; }

        public ICollection<Cinema> Cinema { get; set; }
    }
}
