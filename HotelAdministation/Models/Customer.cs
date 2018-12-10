using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CheckInList = new HashSet<CheckInList>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public int PassportId { get; set; }
        public string Town { get; set; }

        public ICollection<CheckInList> CheckInList { get; set; }
    }
}
