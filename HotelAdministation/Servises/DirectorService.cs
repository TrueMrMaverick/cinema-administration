using HotelAdministation.NewModels;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.Servises
{
    public class DirectorService : BaseEntityService<DirectorViewModel, Director>, IService
    {
        public override Director ToModel(DirectorViewModel model)
        {
            return new Director
            {
                Id = model.Id,
               FirstName = model.FirstName,
               LastName = model.LastName
            };
            
    }

        public override DirectorViewModel ToView(Director model)
        {
            return new DirectorViewModel
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
        }
    }
}
