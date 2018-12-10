using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.ViewModels
{
    public class CinemaViewModel: BaseViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public CinemaStatusViewModel Status { get; set; }
    }
}
