using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.ViewModels
{
    public class ProductionViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}