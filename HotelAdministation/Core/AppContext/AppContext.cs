using System;
using System.IO;
using HotelAdministation.Core.DI;
using HotelAdministation.Views;
using Unity;
using Unity.Lifetime;
using Unity.Registration;

namespace HotelAdministation.Core.AppContext
{
    public class AppContext : IContext
    {
        public AppContext()
        {
            Container = new UnityContainer();
        }

        public UnityContainer Container { get; }

        /// <summary>
        ///     Текущий пользователь системы
        /// </summary>
        public UserViewModel CurrentUser { get; private set; }

        public void Initialize()
        {
            // HACK For demo
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory));
            var DI = new DependencyRegistrar();
            DI.Register(this);
            // Регистрация зависимостей во всех сборках с наличием реализации IDependencyRegistrar
            //AppDomainTypeFinder typeFinder = new AppDomainTypeFinder();
            //var drTypes = typeFinder.FindClassesOfType<IDependencyRegistrar>(true);
            //var drInstances = new List<IDependencyRegistrar>();
            //foreach (var drType in drTypes)
            //    drInstances.Add((IDependencyRegistrar)Activator.CreateInstance(drType));

            ////sort
            //drInstances = drInstances.AsQueryable().OrderBy(t => t.RegisterOrder).ToList();
            //foreach (var dependencyRegistrar in drInstances)
            //    dependencyRegistrar.Register(this);

            // HACK Demo credentials
            //var emloyeesRepository = containerManager.Resolve<IRepository<UserView>>();
            //CurrentUser = emloyeesRepository.GetByID(1);
        }

        //protected abstract void ConfigureContainer(IUnityContainer container);
        //protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        //{
        //    //ConfigureContainer(containerManager);
        //    Initialize();
        //    return new UnityServiceHost(containerManager, serviceType, baseAddresses);
        //}

        public void RegisterType<TFrom, TTo>() where TTo : TFrom
        {
            RegisterType<TFrom, TTo>(false);
        }

        public void RegisterType<TFrom, TTo>(bool ControlledLifetime) where TTo : TFrom
        {
            if (ControlledLifetime) Container.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
            else Container.RegisterType<TFrom, TTo>();
        }

        public void RegisterType(Type from, Type to, params InjectionMember[] injectionMembers)
        {
            Container.RegisterType(from, to, injectionMembers);
        }

        public T Resolve<T>() where T : class
        {
            return Container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return Container.Resolve(type);
        }
    }
}