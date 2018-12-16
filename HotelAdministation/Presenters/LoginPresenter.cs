using HotelAdministation.Core.AppContext;
using HotelAdministation.Presenters;
using HotelAdministation.Services;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public class LoginPresenter : AbstractPresenter<LoginView, LoginPresenter>
    {
        public delegate void LoggedIn();

        private UsersService service;
        public event LoggedIn LoggedInEvent;


        public override void InitializePresenter()
        {
            service = AppGlobalContext.Current.Resolve<UsersService>();
            CreateView();
            ShowView();
        }

        public override void ShowView()
        {
            View.ActivateView();
        }

        public void Login(string login, string password)
        {
            var loggedInUser = service.Login(login, password);
            if (loggedInUser == null)
            {
                View.ShowMessage();
                return;
            }

            AppGlobalContext.CurrentUser = loggedInUser;
            LoggedInEvent();
            Dispose();
        }
    }
}