using System;
using System.Windows.Forms;
using HotelAdministation.Presenters;
using HotelAdministation.Views.Base;

namespace HotelAdministation.Views
{
    public partial class MainView : Form, IView<MainViewPresenter>
    {
        public MainView()
        {
            InitializeComponent();
            mainMenu.Visible = false;
            baseLayout.Visible = false;
        }

        public MainViewPresenter Presenter { get; set; }

        public void ActivateView()
        {
            if (Disposing || IsDisposed) return;

            Show();
            Activate();
            BringToFront();
        }

        public void Show(object mdiParent = null)
        {
            if (mdiParent != null)
            {
                MdiParent = mdiParent as Form;
                WindowState = FormWindowState.Maximized;
            }

            base.Show( /*owner as IWin32Window*/);
        }
        
        private void addSystemUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            Presenter.OpenAddUserDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.Exit();
        }

        private void cinemaListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.InitializeCinemaListView();
        }

        private void filmListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.InitializeFilmListView();
        }
    }
}