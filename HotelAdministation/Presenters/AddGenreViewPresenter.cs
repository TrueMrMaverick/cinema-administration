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
    public class AddGenreViewPresenter : AbstractPresenter<AddGenreView, AddGenreViewPresenter>
    {
        public delegate void DirectorHandler(BaseMetaViewModel model);
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

        public void Add(string name)
        {
            var genreService = AppGlobalContext.Current.Resolve<GenreService>();

            GenreViewModel item = new GenreViewModel
            {
                Name = name
            };

            item = genreService.SaveItem(item);
            Added(item);
        }
    }
}
