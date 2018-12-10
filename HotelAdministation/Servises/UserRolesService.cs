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
    public class UserRolesService : BaseEntityService<UserRolesViewModel, UserRoles>, IService
    {
        public override UserRoles ToModel(UserRolesViewModel model)
        {
            return new UserRoles
            {
                Id = model.Id,
                Name = model.Name
            };

        }

        public override UserRolesViewModel ToView(UserRoles model)
        {
            return new UserRolesViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
