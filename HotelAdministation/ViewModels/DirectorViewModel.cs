using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.ViewModels
{
    public class DirectorViewModel : BaseStaffViewModel
    {
        public override long Id { get; set; }
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
    }
}