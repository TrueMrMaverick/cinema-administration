using HotelAdministation.Core.AppContext;
using HotelAdministation.Services;
using HotelAdministation.ViewModels;
using HotelAdministation.ViewModels.Base;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public class AddOperatorViewPresenter : AbstractPresenter<AddOperatorView, AddOperatorViewPresenter>
    {
        public delegate void DirectorHandler(BaseStaffViewModel model);
        public event DirectorHandler Added;

        public override void InitializePresenter()
        {
            CreateView();
            ShowView();
        }

        public override void ShowView()
        {
            View.ActivateView();
        }

        public void Add(string firstName, string lastName)
        {
            var operatorService = AppGlobalContext.Current.Resolve<OperatorService>();

            OperatorViewModel item = new OperatorViewModel
            {
                FirstName = firstName,
                LastName = lastName
            };

            item = operatorService.SaveItem(item);
            Added(item);
        }
    }
}
