using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Users
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string Password { get; set; }
        public long Role { get; set; }
        public string Email { get; set; }

        public UserRole RoleNavigation { get; set; }
    }
}
