using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class StaffMember
    {
        public StaffMember()
        {
            Floor = new HashSet<Floor>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }

        public ICollection<Floor> Floor { get; set; }
    }
}
