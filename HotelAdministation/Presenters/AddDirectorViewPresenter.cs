using HotelAdministation.Core.AppContext;
using HotelAdministation.Presenters.Enum;
using HotelAdministation.Services;
using HotelAdministation.ViewModels;
using HotelAdministation.ViewModels.Base;
using HotelAdministation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.Presenters
{
    public class AddDirectorViewPresenter : AbstractPresenter<AddDirectorView, AddDirectorViewPresenter>
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
            var directorService = AppGlobalContext.Current.Resolve<DirectorService>();

            DirectorViewModel item = new DirectorViewModel
            {
                FirstName = firstName,
                LastName = lastName
            };

            item = directorService.SaveItem(item);
            Added(item);
        }
    }
}
