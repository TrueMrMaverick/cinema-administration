using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.ViewModels
{
    public class ListOfOperatorsViewModel: BaseViewModel
    {
        public long Id { get; set; }
        public FilmViewModel Film { get; set; }
        public OperatorViewModel Operator { get; set; }
    }
}
