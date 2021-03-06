﻿using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class UserRoles
    {
        public UserRoles()
        {
            Users = new HashSet<Users>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}