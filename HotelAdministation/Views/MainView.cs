using System.Windows.Forms;
using HotelAdministation.Presenters;

namespace HotelAdministation.Views
{
    public partial class MainView : Form, IView<MainViewPresenter>
    {
        public MainViewPresenter Presenter { get; set; }

        public MainView()
        {
            InitializeComponent();
            mainMenu.Visible = false;
            baseLayout.Visible = false;
        }

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

        public virtual bool ShowDialog(object owner)
        {
            return base.ShowDialog(owner as IWin32Window) == DialogResult.OK;
        }

        private void addSystemUserToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Presenter.OpenAddUserDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Presenter.Exit();
        }
    }
}