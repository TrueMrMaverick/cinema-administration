using HotelAdministation.Presenters;
using HotelAdministation.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAdministation.Views
{
    public partial class AddActorView : Form, IView<AddActorViewPresenter>
    {
        public AddActorView()
        {
            InitializeComponent();
        }

        public AddActorViewPresenter Presenter { set; get; }

        public void Show(object mdiParent = null)
        {
            Visible = true;
        }

        public void ActivateView()
        {
            if (Disposing || IsDisposed) return;

            Show();

            BringToFront();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Presenter.Add(firstName.Text, lastName.Text);
            Presenter.Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Presenter.Dispose();
        }
    }
}
