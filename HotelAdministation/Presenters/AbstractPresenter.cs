using System;
using HotelAdministation.Core.AppContext;
using HotelAdministation.Presenters;
using HotelAdministation.Views.Base;

namespace HotelAdministation.Presenters
{
    public abstract class AbstractPresenter<TView, TPresenter> : IPresenter
        where TView : class, IView<TPresenter>
        where TPresenter : class
    {
        private TView view;

        /// <summary>
        ///     Экземпляр представления
        /// </summary>
        public TView View
        {
            get => view;
            set
            {
                view = value;
                if (view != null)
                    view.Presenter = this as TPresenter;
            }
        }

        /// <summary>
        ///     Инициализация презентера
        /// </summary>
        public abstract void InitializePresenter();

        /// <summary>
        ///     Создать представления
        /// </summary>
        public virtual IView CreateView()
        {
            // Начало жизненого цикла представления (форма списка менеджеров)
            View = AppGlobalContext.Current.Resolve<TView>();
            return View;
        }

        /// <summary>
        ///     Отобразтить представление
        /// </summary>
        public abstract void ShowView();


        /// <summary>
        ///     Наличие активного представления
        /// </summary>
        public bool ExistsView()
        {
            return View != null;
        }

        /// <summary>
        ///     Активировать представление в случае если оно было создано раннее
        /// </summary>
        public void ActivateView()
        {
            if (!ExistsView())
                throw new ArgumentException("Невозможно активировать View. Нет экземпляра представления");
            //
            View.ActivateView();
        }

        /// <summary>
        ///     Завершение жизненого цикла презентера
        /// </summary>
        public virtual void Dispose()
        {
            if (View != null)
            {
                View.Close();
                View = null;
            }
        }
    }
}