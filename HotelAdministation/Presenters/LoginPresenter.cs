using HotelAdministation.Core.AppContext;
using HotelAdministation.Services;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public class LoginPresenter : AbstractPresenter<LoginView, LoginPresenter>
    {
        public delegate void LoggedIn();
        public event LoggedIn LoggedInEvent;

        private UserService service;


        public override void Dispose()
        {
            if (View != null)
            {
                View.Close();
                View = null;
            }
        }


        public override void InitializePresenter()
        {
            service = AppGlobalContext.Current.Resolve<UserService>();
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