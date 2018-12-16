using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelAdministation.Presenters;
using HotelAdministation.ViewModels;
using HotelAdministation.Views.Base;

namespace HotelAdministation.Views
{
    public partial class CinemaListView : UserControl, IView<CinemaListViewPresenter>
    {
        public CinemaListView()
        {
            InitializeComponent();
        }

        public CinemaListViewPresenter Presenter { get; set; }        

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

        private void addFilm_Click(object sender, EventArgs e)
        {

        }
    }
}
