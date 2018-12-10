using HotelAdministation.Presenters;
using HotelAdministation.ViewModels;
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
    public partial class AddCustomerView : Form, IView<AddCustomerViewPresenter>
    {
        public AddCustomerView()
        {
            InitializeComponent();
        }

        public List<RoomViewModel> RoomList { get; set; }
        public List<RoomTypeViewModel> RoomTypes { get; set; }

        public AddCustomerViewPresenter Presenter { get; set; }

        public void ActivateView()
        {
            if (Disposing || IsDisposed) return;
            if (RoomList != null && RoomList.Count != 0)
            {
                roomsChooser.DataSource = RoomList;
                roomsChooser.DisplayMember = "Number";
                roomsChooser.ValueMember = "Id";
            }
            else
            {
                roomsChooser.Enabled = false;
            }

            if (RoomTypes != null && RoomList.Count != 0)
            {
                roomTypeChooser.DataSource = RoomTypes;
                roomTypeChooser.DisplayMember = "Type";
                roomTypeChooser.ValueMember = "Id";
            }
            else
            {
                roomTypeChooser.Enabled = false;
            }

            firstNameInput.TextChanged += CheckIfCanAdd;
            secondNameInput.TextChanged += CheckIfCanAdd;
            surNameInput.TextChanged += CheckIfCanAdd;
            passportIdInput.TextChanged += CheckIfCanAdd;
            townInput.TextChanged += CheckIfCanAdd;

            CheckIfCanAdd();
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            var customer = new CustomerViewModel
            {
                FirstName = firstNameInput.Text,
                LastName = surNameInput.Text,
                SecondName = secondNameInput.Text,
                PassportId = Int32.Parse(passportIdInput.Text),
                Town = townInput.Text
            };
            var room = roomsChooser.SelectedItem as RoomViewModel;
            Presenter.AddCustomer(customer, room);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Presenter.Dispose();
        }

        private void roomTypeChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.RoomTypeChanged(roomTypeChooser.SelectedItem as RoomTypeViewModel);
            if (RoomList != null && RoomList.Count != 0)
            {
                roomsChooser.Enabled = true;
                roomsChooser.DataSource = RoomList;
            }
            else
            {
                roomsChooser.SelectedItem = null;
                roomsChooser.Enabled = false;
            }

            CheckIfCanAdd();
        }

        private void CheckIfCanAdd(object sender = null, EventArgs e = null)
        {
            if (
                firstNameInput.Text != ""
                && secondNameInput.Text != ""
                && surNameInput.Text != ""
                && passportIdInput.Text != ""
                && townInput.Text != ""
                && roomsChooser.SelectedItem != null
            )
            {
                addBtn.Enabled = true;
            }
            else
            {
                addBtn.Enabled = false;
            }
        }
    }
}