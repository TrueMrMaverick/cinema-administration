using System.Collections.Generic;
using HotelAdministation.Models;
using HotelAdministation.NewModels;
using HotelAdministation.ViewModels;

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

        ViewModel SafeItem(ViewModel item);
        List<ViewModel> SafeList(List<ViewModel> items);

        ViewModel ToView(Model model);
        Model ToModel(ViewModel model);
    }
}