using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using HotelAdministation.Models;
using HotelAdministation.NewModels;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Services.Base
{
    public abstract class BaseEntityService<ViewModel, Model> : IService<ViewModel, Model>
        where ViewModel : BaseViewModel
        where Model : class, INewModel
    {
        public virtual ViewModel GetById(long id)
        {
            var viewList = new List<ViewModel>();
            foreach (var item in GetModelsFromContext().ToList()) viewList.Add(ToView(item));             
            return viewList.Find(item => item.Id == id);
        }

        public virtual List<ViewModel> GetList()
        {
            var viewList = new List<ViewModel>();
            foreach (var item in GetModelsFromContext().ToList()) viewList.Add(ToView(item));
            return viewList;
        }

        public virtual ViewModel SafeItem(ViewModel item)
        {
            var model = ToModel(item);
            using (var db = new hotelContext())
            {
                var modelList = db.Set<Model>();
                modelList.Add(model);
                db.SaveChanges();
                modelList = db.Set<Model>();
                return ToView(model);
            }
        }

        public virtual List<ViewModel> SafeList(List<ViewModel> items)
        {
            throw new NotImplementedException();
        }

        public abstract Model ToModel(ViewModel model);

        public abstract ViewModel ToView(Model model);

        public virtual List<Model> GetModelsFromContext()
        {
            var modelList = new List<Model>();
            using (var db = new hotelContext())
            {
                modelList = db.Set<Model>().ToList();
            }

            return modelList;
        }
    }
}