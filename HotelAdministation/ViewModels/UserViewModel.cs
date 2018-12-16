using HotelAdministation.ViewModels.Base;
using HotelAdministation.ViewModels.Enums;

namespace HotelAdministation.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string Password { get; set; }
        public UserRoleEnum Role { get; set; }
        public string Email { get; set; }
    }
}