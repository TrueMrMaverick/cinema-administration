using System.Collections.Generic;
using HotelAdministation.Models;
using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.Services.Base
{
    public interface IService
    {
    }

    public interface IService<ViewModel, Model> : IService
        where ViewModel : BaseViewModel
        where Model : class, INewModel
    {
        ViewModel GetById(long id);
        List<ViewModel> GetList();

        ViewModel SaveItem(ViewModel item);
        List<ViewModel> SaveList(List<ViewModel> items);

        ViewModel ToView(Model model);
        Model ToModel(ViewModel model);
    }
}