using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Prize
    {
        public Prize()
        {
            ListOfPrizes = new HashSet<ListOfPrizes>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ListOfPrizes> ListOfPrizes { get; set; }
    }
}