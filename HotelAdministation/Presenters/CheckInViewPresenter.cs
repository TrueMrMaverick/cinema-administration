using System.Collections.Generic;
using HotelAdministation.Core.AppContext;
using HotelAdministation.Services;
using HotelAdministation.Views;
using System.Windows.Forms;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Presenters
{
    public class CheckInViewPresenter : AbstractPresenter<CheckInView, CheckInViewPresenter>
    {
        private readonly CheckInListService service = AppGlobalContext.Current.Resolve<CheckInListService>();
        public Form ParentView { get; set; }

        public override void Dispose()
        {
            View.Dispose();
        }

        public override void InitializePresenter()
        {
            if (ParentView != null)
            {
                CreateView();
                SetupView();
                ShowView();
            }
        }

        public override void ShowView()
        {
            UpdateData();
            View.ActivateView();
        }

        private void SetupView()
        {
            View.Dock = System.Windows.Forms.DockStyle.Fill;
            View.Size = new System.Drawing.Size(0, 0);
        }

        public void InitializeAddCustomer()
        {
            var addCustomerPresenter = AppGlobalContext.Current.Resolve<AddCustomerViewPresenter>();
            addCustomerPresenter.InitializePresenter();
            addCustomerPresenter.CustomerAddedEvent += UpdateData;
        }

        private void UpdateData()
        {
            View.UpdateData(convertListToShownViewModel(service.GetList()));
        }

        private CheckInListDataTableViewModel convertToShownViewModel(CheckInListViewModel viewModel)
        {
            return new CheckInListDataTableViewModel
            {
                FirstName = viewModel.Customer.FirstName,
                LastName = viewModel.Customer.LastName,
                SecondName = viewModel.Customer.SecondName,
                PassportId = viewModel.Customer.PassportId,
                Town = viewModel.Customer.Town,
                Number = viewModel.Room.Number,
                PhoneNumber = viewModel.Room.PhoneNumber,
                Type = viewModel.Room.Type.Type,
                Price = viewModel.Room.Type.Price
            };
        }

        private List<CheckInListDataTableViewModel> convertListToShownViewModel(List<CheckInListViewModel> viewModels)
        {
            var newViewModels = new List<CheckInListDataTableViewModel>();
            foreach (var item in viewModels)
            {
                newViewModels.Add(convertToShownViewModel(item));
            }

            return newViewModels;
        }
    }
}