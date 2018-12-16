using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Operator
    {
        public Operator()
        {
            ListOfOperators = new HashSet<ListOfOperators>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<ListOfOperators> ListOfOperators { get; set; }
    }
}