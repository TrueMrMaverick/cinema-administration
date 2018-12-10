using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class CheckInList
    {
        public long Id { get; set; }
        public long Room { get; set; }
        public long Customer { get; set; }
        public DateTime DateOfArrival { get; set; }

        public Customer CustomerNavigation { get; set; }
        public Room RoomNavigation { get; set; }
    }
}
