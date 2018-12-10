using HotelAdministation.Core.AppContext;
using HotelAdministation.Presenters;
using HotelAdministation.Services.Base;
using HotelAdministation.Servises;
using HotelAdministation.Views;

namespace HotelAdministation.Core.DI
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(IContext appContext)
        {
            // services
            appContext.RegisterType<IService, ActorService>();


            // views
            appContext.RegisterType<IView, MainView>();
            appContext.RegisterType<IView, LoginView>();
            appContext.RegisterType<IView, CheckInView>();
            appContext.RegisterType<IView, AddCustomerView>();
            appContext.RegisterType<IView, AddUserView>();

            // presenters
            appContext.RegisterType<IPresenter, LoginPresenter>();
            appContext.RegisterType<IPresenter, MainViewPresenter>();
            appContext.RegisterType<IPresenter, CheckInViewPresenter>();
            appContext.RegisterType<IPresenter, AddCustomerViewPresenter>();
            appContext.RegisterType<IPresenter, AddUserViewPresenter>();
        }
    }
}