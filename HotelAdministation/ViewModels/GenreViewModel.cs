using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.ViewModels
{
    public class GenreViewModel : BaseMetaViewModel
    {
        public override long Id { get; set; }
        public override string Name { get; set; }
    }
}