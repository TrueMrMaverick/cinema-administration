using System;
using System.Windows.Forms;
using HotelAdministation.Presenters;

namespace HotelAdministation.Views
{
    public partial class LoginView : UserControl, IView<LoginPresenter>
    {
        public LoginView()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        public LoginPresenter Presenter { get; set; }

        public void ActivateView()
        {
            if (Disposing || IsDisposed) return;

            Dock = System.Windows.Forms.DockStyle.Fill;
            Size = new System.Drawing.Size(0, 0);

            Show();

            BringToFront();
        }

        public void Show(object mdiParent = null)
        {
            if (mdiParent != null) Parent = mdiParent as Form;
            Visible = true;
        }

        public bool ShowDialog(object owner)
        {
            return false; /*base.ShowDialog(owner as IWin32Window) == System.Windows.Forms.DialogResult.OK;*/
        }

        public void Close()
        {
            Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Presenter.Login(login.Text, password.Text);
        }

        public void ShowMessage()
        {
            errorMsg.Visible = true;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
        }
    }
}