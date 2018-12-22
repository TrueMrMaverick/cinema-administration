using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdministation.Core.AppContext;
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

        public List<DirectorViewModel> GetDirectorsById(long filmId)
        {
            var listOfDirectorsService = AppGlobalContext.Current.Resolve<ListOfDirectorsService>();
            var listOfDirectors = listOfDirectorsService.GetByFilmId(filmId);

            return listOfDirectors.Select(x => x.Director).ToList();
        }

        public List<ActorViewModel> GetActorsById(long filmId)
        {
            var listOfActorsService = AppGlobalContext.Current.Resolve<ListOfActorsService>();
            var listOfDirectors = listOfActorsService.GetByFilmId(filmId);

            return listOfDirectors.Select(x => x.Actor).ToList();
        }

        public List<OperatorViewModel> GetOperatorsById(long filmId)
        {
            var listOfOperatorsService = AppGlobalContext.Current.Resolve<ListOfOperatorsService>();
            var listOfDirectors = listOfOperatorsService.GetByFilmId(filmId);

            return listOfDirectors.Select(x => x.Operator).ToList();
        }

        public List<ProductionViewModel> GetProductionsById(long filmId)
        {
            var listOfProductionsService = AppGlobalContext.Current.Resolve<ListOfProductionsService>();
            var listOfDirectors = listOfProductionsService.GetByFilmId(filmId);

            return listOfDirectors.Select(x => x.Production).ToList();
        }

        public List<PrizeViewModel> GetPrizesById(long filmId)
        {
            var listOfPrizesService = AppGlobalContext.Current.Resolve<ListOfPrizesService>();
            var listOfDirectors = listOfPrizesService.GetByFilmId(filmId);

            return listOfDirectors.Select(x => x.Prize).ToList();
        }

        public List<GenreViewModel> GetGenresById(long filmId)
        {
            var listOfGenresService = AppGlobalContext.Current.Resolve<ListOfGenresService>();
            var listOfDirectors = listOfGenresService.GetByFilmId(filmId);

            return listOfDirectors.Select(x => x.Genre).ToList();
        }
    }
}