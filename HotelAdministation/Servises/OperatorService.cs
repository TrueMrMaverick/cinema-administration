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
    public class OperatorService : BaseEntityService<OperatorViewModel, Operator>, IService
    {
        public override Operator ToModel(OperatorViewModel model)
        {
            return new Operator
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

        }

        public override OperatorViewModel ToView(Operator model)
        {
            return new OperatorViewModel
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
        }
    }
}
