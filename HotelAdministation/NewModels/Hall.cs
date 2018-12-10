using System;
using System.Collections.Generic;

namespace HotelAdministation.NewModels
{
    public partial class Hall
    {
        public Hall()
        {
            HallList = new HashSet<HallList>();
            Seance = new HashSet<Seance>();
        }

        public long Id { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public int TicketsLeft { get; set; }

        public ICollection<HallList> HallList { get; set; }
        public ICollection<Seance> Seance { get; set; }
    }
}
