using HotelAdministation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels.Enums;

namespace HotelAdministation.Services
{
    public class UserRolesService : BaseTypeService<UserRoleEnum, UserRoles>
    {
        public override UserRoleEnum GetInModelType(int id)
        {
            var modelList = GetModelsFromContext();
            return (UserRoleEnum) Enum.ToObject(typeof(UserRoleEnum), GetModelsFromContext()[id - 1].Id);
        }
    }
}