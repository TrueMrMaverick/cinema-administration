using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.Models;
using HotelAdministation.Core.AppContext;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Services
{
    public class UsersService : BaseEntityService<UserViewModel, Users>
    {
        public UserViewModel Login(string login, string password)
        {
            var users = GetModelsFromContext();
            var loggedInUser = users.Find(user => user.Email == login && user.Password == password);

            if (loggedInUser == null) return null;

            return ToView(loggedInUser);
        }

        public override Users ToModel(UserViewModel model)
        {
            return new Users
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                SecondName = model.SecondName,
                Password = model.Password,
                Role = (int) model.Role,
                Email = model.Email
            };
        }

        public override UserViewModel ToView(Users model)
        {
            var usersRoleService = AppGlobalContext.Current.Resolve<UserRolesService>();
            return new UserViewModel
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                SecondName = model.SecondName,
                Password = model.Password,
                Role = usersRoleService.GetInModelType(unchecked((int) model.Role)),
                Email = model.Email
            };
        }

        public UserViewModel SafeItem(UserViewModel item, string password)
        {
            var model = ToModel(item);
            model.Password = password;
            using (var db = new cinemaContext())
            {
                var modelList = db.Set<Users>();
                modelList.Add(model);
                db.SaveChanges();
                modelList = db.Set<Users>();
                return ToView(model);
            }
        }
    }
}