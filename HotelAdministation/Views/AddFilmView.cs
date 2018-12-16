using System.Windows.Forms;
using HotelAdministation.Presenters;
using HotelAdministation.Views.Base;

namespace HotelAdministation.Views
{
    public partial class AddFilmView : Form, IView<AddFilmViewPresenter>
    {
        public AddFilmView()
        {
            InitializeComponent();
        }

        public AddFilmViewPresenter Presenter { get; set; }

        public void Show(object mdiParent = null)
        {
            if (Disposing || IsDisposed) return;
            
            Show();

            BringToFront();
        }

        public void ActivateView()
        {
        }
    }
}
