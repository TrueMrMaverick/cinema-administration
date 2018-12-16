using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Production
    {
        public Production()
        {
            ListOfProductions = new HashSet<ListOfProductions>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ListOfProductions> ListOfProductions { get; set; }
    }
}