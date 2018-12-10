using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.ViewModels
{
    public class HallViewModel: BaseViewModel
    {
        public long Id { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public int TicketsLeft { get; set; }
    }
}
