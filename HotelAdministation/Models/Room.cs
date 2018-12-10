using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Room
    {
        public Room()
        {
            CheckInList = new HashSet<CheckInList>();
            Floor = new HashSet<Floor>();
        }

        public long Id { get; set; }
        public int Number { get; set; }
        public long Type { get; set; }
        public int PhoneNumber { get; set; }

        public RoomType TypeNavigation { get; set; }
        public ICollection<CheckInList> CheckInList { get; set; }
        public ICollection<Floor> Floor { get; set; }
    }
}
