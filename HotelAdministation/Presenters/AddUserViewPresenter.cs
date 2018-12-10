using HotelAdministation.Core.AppContext;
using HotelAdministation.Services;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public class AddUserViewPresenter: AbstractPresenter<AddUserView, AddUserViewPresenter>
    {
        
        private readonly UserService userService = AppGlobalContext.Current.Resolve<UserService>();

        
        public override void InitializePresenter()
        {
            CreateView();
            ShowView();
        }

        public override void ShowView()
        {
            View.ActivateView();
        }

        public override void Dispose()
        {
            View?.Close();
        }

        public bool AddUser(UserViewModel user, string password)
        {
            if (userService.GetList().Find(item => item.Email == user.Email) != null)
            {
                return false;
            }
            userService.SafeItem(user, password);
            Dispose();
            return true;
        }
    }
}