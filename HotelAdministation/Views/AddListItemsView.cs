using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAdministation.Presenters;
using HotelAdministation.Presenters.Enum;
using HotelAdministation.Views.Base;

namespace HotelAdministation.Views
{
    public partial class AddListItemsView : Form, IView<AddListItemsViewPresenter>
    {
        public AddListItemsView()
        {
            InitializeComponent();
        }

        public AddListItemsViewPresenter Presenter { get; set; }

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

        private void addButton_Click(object sender, EventArgs e)
        {
            Presenter.InitializeAddView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Presenter.Select();
            Presenter.Dispose();
        }
    }
}
