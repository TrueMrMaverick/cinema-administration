using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.ViewModels
{
    public class ListOfOperatorsViewModel : BaseViewModel
    {
        public override long Id { get; set; }
        public FilmViewModel Film { get; set; }
        public OperatorViewModel Operator { get; set; }
    }
}