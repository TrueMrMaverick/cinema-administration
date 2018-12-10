﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.ViewModels
{
    public class ListOfDirectorsViewModel: BaseViewModel
    {
        public long Id { get; set; }
        public FilmViewModel Film { get; set; }
        public DirectorViewModel Director { get; set; }
    }
}