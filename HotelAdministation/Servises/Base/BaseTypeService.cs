﻿using System.Collections.Generic;
using System.Linq;
using HotelAdministation.Models;

namespace HotelAdministation.Services.Base
{
    public abstract class BaseTypeService<Type, Model> : ITypeService where Model: class, IModel
    {
        public abstract Type GetInModelType(int id);

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