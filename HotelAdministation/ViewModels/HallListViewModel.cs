using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.ViewModels
{
    public class HallListViewModel: BaseViewModel
    {
        public long Id { get; set; }
        public CinemaViewModel Cinema { get; set; }
        public HallViewModel Hall { get; set; }
    }
}
