using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Floor
    {
        public long Id { get; set; }
        public long Room { get; set; }
        public long StaffMember { get; set; }
        public TimeSpan Date { get; set; }

        public Room RoomNavigation { get; set; }
        public StaffMember StaffMemberNavigation { get; set; }
    }
}
