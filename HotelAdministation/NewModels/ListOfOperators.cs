using System;
using System.Collections.Generic;

namespace HotelAdministation.NewModels
{
    public partial class ListOfOperators
    {
        public long Id { get; set; }
        public long Film { get; set; }
        public long Operator { get; set; }

        public Film FilmNavigation { get; set; }
        public Operator OperatorNavigation { get; set; }
    }
}
