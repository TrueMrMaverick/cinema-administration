using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.Models;
using HotelAdministation.Services.Base;
using HotelAdministation.ViewModels;

namespace HotelAdministation.Services
{
    public class GenreService : BaseEntityService<GenreViewModel, Genre>, IService
    {
        public override Genre ToModel(GenreViewModel model)
        {
            return new Genre
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public override GenreViewModel ToView(Genre model)
        {
            return new GenreViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}