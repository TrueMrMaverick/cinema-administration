using HotelAdministation.Core.AppContext;
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
    public class UsersService : BaseEntityService<UsersViewModel, Users>, IService
    {
        public override Users ToModel(UsersViewModel model)
        {
            return new Users
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                SecondName = model.SecondName,
                Password = model.Password,
                Role = model.Role.Id,
                Email = model.Email
            };
        }

        public override UsersViewModel ToView(Users model)
        {
            var usersRoleService = AppGlobalContext.Current.Resolve<UserRolesService>();
            return new UsersViewModel
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                SecondName = model.SecondName,
                Password = model.Password,
                Role = usersRoleService.GetById(model.Role),
                Email = model.Email
            };

        }
    }
}
