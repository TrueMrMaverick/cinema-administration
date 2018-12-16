using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Area
    {
        public Area()
        {
            ListOfAreas = new HashSet<ListOfAreas>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ListOfAreas> ListOfAreas { get; set; }
    }
}