using System.Windows.Forms;
using HotelAdministation.Presenters;
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
    }
}
