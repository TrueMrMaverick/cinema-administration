using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.ViewModels
{
    public class HallListViewModel : BaseViewModel
    {
        public override long Id { get; set; }
        public CinemaViewModel Cinema { get; set; }
        public HallViewModel Hall { get; set; }
    }
}