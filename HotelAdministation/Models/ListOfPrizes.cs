using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class ListOfPrizes
    {
        public long Id { get; set; }
        public long Prize { get; set; }
        public long Film { get; set; }

        public Film FilmNavigation { get; set; }
        public Prize PrizeNavigation { get; set; }
    }
}