using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelAdministation.Presenters;
using HotelAdministation.ViewModels.Enums;

namespace HotelAdministation.Views
{

    class UserRoleItem
    {
        public string Name { get; set; }
    }
    
    public partial class AddUserView : Form, IView<AddUserViewPresenter>
    {
        public AddUserView()
        {
            InitializeComponent();
        }
        
        public AddUserViewPresenter Presenter { get; set; }

        public void Show(object mdiParent = null)
        {
            if (mdiParent != null) Parent = mdiParent as Form;
            Visible = true;
        }

        public bool ShowDialog(object owner)
        {
            return false; /*base.ShowDialog(owner as IWin32Window) == System.Windows.Forms.DialogResult.OK;*/
        }

        public void ActivateView()
        {
            var roles = new List<UserRoleItem>();
            roles.Add(new UserRoleItem {Name = "Администратор"});
            roles.Add(new UserRoleItem {Name = "Пользователь"});
            roleChooser.DataSource = roles;
            roleChooser.DisplayMember = "Name";
            roleChooser.ValueMember = "Name";
            
            firstNameInput.TextChanged += CheckIfCanAdd;
            secondNameInput.TextChanged += CheckIfCanAdd;
            surNameInput.TextChanged += CheckIfCanAdd;
            passwordInput.TextChanged += CheckIfCanAdd;
            emailInput.TextChanged += CheckIfCanAdd;
            
            CheckIfCanAdd();
            Show();

            BringToFront();
        }

        private void CheckIfCanAdd(object sender = null, EventArgs e = null)
        {
            if (
                firstNameInput.Text != ""
                && secondNameInput.Text != ""
                && surNameInput.Text != ""
                && passwordInput.Text != ""
                && emailInput.Text != ""
                && roleChooser.SelectedItem != null
            )
            {
                addBtn.Enabled = true;
            }
            else
            {
                addBtn.Enabled = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Presenter.Dispose();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var user = new UserViewModel
            {
                FirstName = firstNameInput.Text,
                LastName = surNameInput.Text,
                SecondName = secondNameInput.Text,
                Email = emailInput.Text
            };

            switch (roleChooser.SelectedValue)
            {
                    case "Администратор":
                        user.Role = UserRoleEnum.ADMIN;
                        break;
                    case "Пользователь":
                        user.Role = UserRoleEnum.USER;
                        break;
            }
            
            if (Presenter.AddUser(user, passwordInput.Text))
            {
                loginErrorLabel.Visible = false;
            }
            else
            {
                loginErrorLabel.Visible = true;
            }
            
        }
    }
}
