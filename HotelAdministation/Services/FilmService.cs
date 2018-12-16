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
    public class FilmService : BaseEntityService<FilmViewModel, Film>, IService
    {
        public override Film ToModel(FilmViewModel model)
        {
            return new Film
            {
                Id = model.Id,
                Name = model.Name,
                Duration = model.Duration,
                Image = model.Image,
                RentalPrice = model.RentalPrice
            };
        }

        public override FilmViewModel ToView(Film model)
        {
            return new FilmViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Duration = model.Duration,
                Image = model.Image,
                RentalPrice = model.RentalPrice
            };
        }
    }
}