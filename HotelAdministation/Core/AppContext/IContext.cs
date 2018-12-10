using System;
using HotelAdministation.ViewModels;
using HotelAdministation.Views;
using Unity;
using Unity.Registration;

namespace HotelAdministation.Core.AppContext
{
    public interface IContext
    {
        /// <summary>
        ///     Текущий пользователь
        /// </summary>
        UsersViewModel CurrentUser { get; }

        UnityContainer Container { get; }

        /// <summary>
        ///     Инициализация контекста приложения
        /// </summary>
        void Initialize();

        /// <summary>
        ///     Зарегистрировать тип
        /// </summary>
        void RegisterType<TFrom, TTo>() where TTo : TFrom;

        void RegisterType<TFrom, TTo>(bool ControlledLifetime) where TTo : TFrom;

        /// <summary>
        ///     Зарегистрировать тип
        /// </summary>
        void RegisterType(Type from, Type to, params InjectionMember[] injectionMembers);

        /// <summary>
        ///     Разрешить зависимость
        /// </summary>
        T Resolve<T>() where T : class;

        /// <summary>
        ///     Разрешить зависимость
        /// </summary>
        object Resolve(Type type);
    }
}