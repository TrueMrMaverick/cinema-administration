using HotelAdministation.Core.AppContext;

namespace HotelAdministation.Core.DI
{
    public interface IDependencyRegistrar
    {
        void Register(IContext appContext);
    }
}