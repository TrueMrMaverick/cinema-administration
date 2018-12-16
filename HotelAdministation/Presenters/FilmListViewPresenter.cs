using System.Windows.Forms;
using HotelAdministation.Core.AppContext;
using HotelAdministation.Services;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public class FilmListViewPresenter: AbstractPresenter<FilmListView, FilmListViewPresenter>
    {
        
        public Form ParentView { get; set; }

        FilmService filmService = AppGlobalContext.Current.Resolve<FilmService>();

        
        public override void InitializePresenter()
        {
            if (ParentView != null)
            {
                CreateView();
                SetupView();
                ShowView();
            }
        }

        public override void ShowView()
        {
            UpdateData();
            View.ActivateView();
        }
        
        private void SetupView()
        {
            View.Dock = DockStyle.Fill;
            View.Size = new System.Drawing.Size(0, 0);
        }
        
        private void UpdateData()
        {
            View.FilmDataGridView.DataSource = filmService.GetList();
        }
    }
}