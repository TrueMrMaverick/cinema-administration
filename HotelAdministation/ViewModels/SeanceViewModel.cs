using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.ViewModels
{
    public class SeanceViewModel: BaseViewModel
    {
        public long Id { get; set; }
        public HallViewModel Hall { get; set; }
        public FilmViewModel Film { get; set; }
        public DateTime Date { get; set; }
    }
}
