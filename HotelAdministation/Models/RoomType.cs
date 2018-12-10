using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class RoomType
    {
        public RoomType()
        {
            Room = new HashSet<Room>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public ICollection<Room> Room { get; set; }
    }
}
