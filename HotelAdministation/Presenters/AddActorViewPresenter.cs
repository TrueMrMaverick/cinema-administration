using HotelAdministation.Core.AppContext;
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
    public class AddActorViewPresenter : AbstractPresenter<AddActorView, AddActorViewPresenter>
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
            var actorService = AppGlobalContext.Current.Resolve<ActorService>();

            ActorViewModel item = new ActorViewModel
            {
                FirstName = firstName,
                LastName = lastName
            };

            Added(actorService.SaveItem(item));
        }
    }
}
