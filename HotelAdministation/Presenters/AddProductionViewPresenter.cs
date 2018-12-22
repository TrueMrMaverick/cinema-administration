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
    public class AddProductionViewPresenter : AbstractPresenter<AddProductionView, AddProductionViewPresenter>
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
            var productionService = AppGlobalContext.Current.Resolve<ProductionService>();

            ProductionViewModel item = new ProductionViewModel
            {
                Name = name
            };

            item = productionService.SaveItem(item);
            Added(item);
        }
    }
}
