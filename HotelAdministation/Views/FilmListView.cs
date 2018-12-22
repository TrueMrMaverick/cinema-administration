using System.Windows.Forms;
using HotelAdministation.Presenters;
using HotelAdministation.ViewModels;
using HotelAdministation.Views.Base;

namespace HotelAdministation.Views
{
    public partial class FilmListView : UserControl, IView<FilmListViewPresenter>
    {
        public FilmListView()
        {
            InitializeComponent();
        }

        public FilmListViewPresenter Presenter { get; set; }

        public void Show(object mdiParent = null)
        {
            if (mdiParent != null) Parent = mdiParent as Form;
            Visible = true;
        }

        public void ActivateView()
        {
            if (Disposing || IsDisposed) return;
            
            Show();

            BringToFront();
        }

        public void Close()
        {
            Visible = false;
        }

        private void addFilmButton_Click(object sender, System.EventArgs e)
        {
            Presenter.InitializeAddFilmView();
        }

        private void editFilmButton_Click(object sender, System.EventArgs e)
        {
            Presenter.InitializeAddFilmView((long)FilmDataGridView.SelectedRows[0].Cells["Id"].Value);
        }
    }
}
