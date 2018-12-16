namespace HotelAdministation.Views.Base
{
    /// <summary>
    ///     Интерфейс представления
    /// </summary>
    public interface IView<TPresenter> : IView
    {
        /// <summary>
        ///     Presenter представления
        /// </summary>
        TPresenter Presenter { set; get; }
    }

    public interface IView
    {
        ///// <summary>
        ///// Контекст данных представления
        ///// </summary>
        //object DataContext { get; set; }

        ///// <summary>
        ///// Привязка данных
        ///// </summary>
        //void BindData();

        /// <summary>
        ///     Отобразить представление
        /// </summary>
        void Show(object mdiParent = null);

        /// <summary>
        ///     Перевести форму в начало z-порядка
        /// </summary>
        void ActivateView();

        /// <summary>
        ///     Закрыть представление
        /// </summary>
        void Close();
    }
}