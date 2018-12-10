using System;
using HotelAdministation.Core.AppContext;
using HotelAdministation.Services;
using HotelAdministation.ViewModels;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public class AddCustomerViewPresenter : AbstractPresenter<AddCustomerView, AddCustomerViewPresenter>
    {

        public delegate void CustomerAdded();
        public event CustomerAdded CustomerAddedEvent;
        
        private readonly RoomService roomService = AppGlobalContext.Current.Resolve<RoomService>();
        private readonly CustomerService customerService = AppGlobalContext.Current.Resolve<CustomerService>();
        private readonly RoomTypeService roomTypeService = AppGlobalContext.Current.Resolve<RoomTypeService>();
        private readonly CheckInListService checkInListService = AppGlobalContext.Current.Resolve<CheckInListService>();

        public override void Dispose()
        {
            View?.Close();
        }

        public override void InitializePresenter()
        {
            CreateView();
            ShowView();
        }

        public override void ShowView()
        {
            View.RoomTypes = roomTypeService.GetList();
            View.RoomList = roomService.GetFreeRoomsOfType(View.RoomTypes[0]);
            View.ActivateView();
        }

        public void RoomTypeChanged(RoomTypeViewModel type)
        {
            View.RoomList = roomService.GetFreeRoomsOfType(type);
        }

        public void AddCustomer(CustomerViewModel customer, RoomViewModel room)
        {
            if (customerService.GetList().Find(item => item.Equals(customer)) == null)
            {
                customer = customerService.SafeItem(customer);
            }
            var checkInListItem = new CheckInListViewModel
            {
                Customer = customer,
                Room = room,
                DateOfArrival = DateTime.Now
            };
            checkInListService.SafeItem(checkInListItem);
            CustomerAddedEvent();
            Dispose();
        }
    }
}
