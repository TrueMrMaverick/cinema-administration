using System.Collections.Generic;
using System.Windows.Forms;
using HotelAdministation.Presenters;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Views
{
    public partial class CheckInView : UserControl, IView<CheckInViewPresenter>
    {
        public CheckInView()
        {
            InitializeComponent();
        }

        public List<CheckInListDataTableViewModel> ViewModelList { get; set; }

        public CheckInViewPresenter Presenter { get; set; }

        public void ActivateView()
        {
            if (Disposing || IsDisposed) return;
            if (ViewModelList != null) checkInList.DataSource = ViewModelList;

            Show();

            BringToFront();
        }

        public void Close()
        {
            Visible = false;
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

        private void AddCustomer_Click(object sender, System.EventArgs e)
        {
            Presenter.InitializeAddCustomer();
        }

        public void UpdateData(List<CheckInListDataTableViewModel> viewModelList)
        {
            ViewModelList = viewModelList;
            checkInList.DataSource = viewModelList;
            checkInList.Refresh();
        }
    }
}