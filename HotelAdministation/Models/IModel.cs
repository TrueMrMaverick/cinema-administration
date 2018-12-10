namespace HotelAdministation.Models
{
    public interface IModel
    {
    }

    public partial class CheckInList : IModel
    {
    }

    public partial class Customer : IModel
    {
    }

    public partial class DbLog : IModel
    {
    }

    public partial class Floor : IModel
    {
    }

    public partial class Room : IModel
    {
    }

    public partial class RoomType : IModel
    {
    }

    public partial class StaffMember : IModel
    {
    }

    public partial class UserRole : IModel
    {
    }

    public partial class Users : IModel
    {
        public bool Equals(Users user)
        {
            if (user == null)
            {
                return false;
            }
            return Email == user.Email;
        }
    }
}