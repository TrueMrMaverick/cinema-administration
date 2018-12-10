using HotelAdministation.Core.AppContext;
using HotelAdministation.ViewModels.Enums;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public class MainViewPresenter : AbstractPresenter<MainView, MainViewPresenter>
    {

        private object CurrentPresenter { get; set; }

        public override void Dispose()
        {
            View.Dispose();
        }

        public override void InitializePresenter()
        {
            CreateView();
            ShowView();
            if (AppGlobalContext.CurrentUser == null) LogIn();
        }

        public override void ShowView()
        {
            
            View.ActivateView();
        }

        private void LogIn()
        {
            var loginPresenter = AppGlobalContext.Current.Resolve<LoginPresenter>();
            loginPresenter.InitializePresenter();
            loginPresenter.LoggedInEvent += InitializeBaseView;
            View.Controls.Add(loginPresenter.View);
        }

        public void InitializeBaseView()
        {
            View.mainMenu.Visible = true;
            View.baseLayout.Visible = true;
            View.addSystemUserToolStripMenuItem.Visible = AppGlobalContext.CurrentUser.Role == UserRoleEnum.ADMIN;
            var checkInViewPresenter = AppGlobalContext.Current.Resolve<CheckInViewPresenter>();
            checkInViewPresenter.ParentView = View;
            checkInViewPresenter.InitializePresenter();
            View.baseLayout.Controls.Add(checkInViewPresenter.View);
            CurrentPresenter = checkInViewPresenter;
        }

        public void OpenAddUserDialog()
        {
            if (AppGlobalContext.CurrentUser.Role == UserRoleEnum.ADMIN)
            {
                var addUserViewPresenter = AppGlobalContext.Current.Resolve<AddUserViewPresenter>();
                addUserViewPresenter.InitializePresenter();
            }
        }

        public void Exit()
        {
            AppGlobalContext.CurrentUser = null;
            (CurrentPresenter as IPresenter).Dispose();
            View.baseLayout.Controls.Clear();
            View.mainMenu.Visible = false;
            View.baseLayout.Visible = false;
            LogIn();
        }
    }
}