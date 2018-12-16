using HotelAdministation.Core.AppContext;
using HotelAdministation.Presenters;
using HotelAdministation.ViewModels.Enums;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public class MainViewPresenter : AbstractPresenter<MainView, MainViewPresenter>
    {
        private object CurrentPresenter { get; set; }

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
            InitializeCinemaListView();
        }


        public void InitializeCinemaListView()
        {
            CloseCurrentPresenter();
            var cinemaListViewPresenter = AppGlobalContext.Current.Resolve<CinemaListViewPresenter>();
            cinemaListViewPresenter.ParentView = View;
            cinemaListViewPresenter.InitializePresenter();
            View.baseLayout.Controls.Add(cinemaListViewPresenter.View);
            CurrentPresenter = cinemaListViewPresenter;
        }
        
        public void InitializeFilmListView()
        {
            CloseCurrentPresenter();
            var filmListViewPresenter = AppGlobalContext.Current.Resolve<FilmListViewPresenter>();
            filmListViewPresenter.ParentView = View;
            filmListViewPresenter.InitializePresenter();
            View.baseLayout.Controls.Add(filmListViewPresenter.View);
            CurrentPresenter = filmListViewPresenter;
        }
        
//        public void OpenAddUserDialog()
//        {
//            if (AppGlobalContext.CurrentUser.Role == UserRoleEnum.ADMIN)
//            {
//                var addUserViewPresenter = AppGlobalContext.Current.Resolve<AddUserViewPresenter>();
//                addUserViewPresenter.InitializePresenter();
//            }
//        }

        public void Exit()
        {
            AppGlobalContext.CurrentUser = null;
            (CurrentPresenter as IPresenter)?.Dispose();
            View.baseLayout.Controls.Clear();
            View.mainMenu.Visible = false;
            View.baseLayout.Visible = false;
            LogIn();
        }
        
        private void CloseCurrentPresenter()
        {
            if (CurrentPresenter != null)
            {
                (CurrentPresenter as IPresenter).Dispose();
                View.baseLayout.Controls.Clear();
            }
        }
    }
}