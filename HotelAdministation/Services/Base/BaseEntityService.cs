﻿using System;
using System.Collections.Generic;
using System.Linq;
using HotelAdministation.Models;
using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.Services.Base
{
    public abstract class BaseEntityService<TViewModel, TModel> : IService<TViewModel, TModel>
        where TModel : class, INewModel where TViewModel : BaseViewModel
    {
        public virtual TViewModel GetById(long id)
        {
            var viewList = new List<TViewModel>();
            foreach (var item in GetModelsFromContext().ToList()) viewList.Add(ToView(item));
            return viewList.Find(item => item.Id == id);
        }

        public virtual List<TViewModel> GetList()
        {
            var viewList = new List<TViewModel>();
            foreach (var item in GetModelsFromContext().ToList()) viewList.Add(ToView(item));
            return viewList;
        }

        public virtual TViewModel SafeItem(TViewModel item)
        {
            var model = ToModel(item);
            using (var db = new cinemaContext())
            {
                var modelList = db.Set<TModel>();
                modelList.Add(model);
                db.SaveChanges();
                modelList = db.Set<TModel>();
                return ToView(model);
            }
        }

        public virtual List<TViewModel> SafeList(List<TViewModel> items)
        {
            throw new NotImplementedException();
        }

        public abstract TModel ToModel(TViewModel model);

        public abstract TViewModel ToView(TModel model);

        public virtual List<TModel> GetModelsFromContext()
        {
            var modelList = new List<TModel>();
            using (var db = new cinemaContext())
            {
                modelList = db.Set<TModel>().ToList();
            }

            return modelList;
        }
    }
}