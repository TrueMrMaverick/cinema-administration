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
            throw new NotImplementedException();
        }

        public void ActivateView()
        {
            throw new NotImplementedException();
        }
    }
}
