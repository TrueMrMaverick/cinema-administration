using System;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public interface IPresenter : IDisposable
    {
        /// <summary>
        ///     Инициализация презентера
        /// </summary>
        void InitializePresenter();

        /// <summary>
        ///     Отобразить представление
        /// </summary>
        void ShowView();

        /// <summary>
        ///     Создать представление
        /// </summary>
        IView CreateView();

        /// <summary>
        ///     Существует в наличии активная View
        /// </summary>
        bool ExistsView();

        /// <summary>
        ///     Активировать представление
        /// </summary>
        void ActivateView();
    }

    ///// <summary>
    ///// Интерфейс презентера
    ///// </summary>
    //public interface IPresenter<TView> : IPresenter
    //{
    //    TView View { get; set; }
    //}
}