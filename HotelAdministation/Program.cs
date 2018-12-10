using System;
using System.Windows.Forms;
using HotelAdministation.Core.AppContext;
using HotelAdministation.Presenters;

namespace HotelAdministation
{
    internal static class Program
    {
        //Scaffold-DbContext "Host=localhost;Database=hotel;Username=postgres;Password=gjyjvfhtdf7" Npgsql.EntityFrameworkCore.PostgreSQL -o Models -force 

            //Кошка
        //Scaffold-DbContext "Host=localhost;Database=cinema;Username=user;Password=gjyjvfhtdf7" Npgsql.EntityFrameworkCore.PostgreSQL -o NewModels -force

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            AppGlobalContext.Initialize(false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var mainPresenter = AppGlobalContext.Current.Resolve<MainViewPresenter>();
            mainPresenter.InitializePresenter();
            Application.Run(mainPresenter.View);

            //var loginPresenter = AppGlobalContext.Current.Resolve<LoginPresenter>();
            //loginPresenter.InitializePresenter();
            //Application.Run(loginPresenter.View as Form);
        }
    }
}