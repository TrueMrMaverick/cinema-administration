using HotelAdministation.Services;
using HotelAdministation.ViewModels;
using HotelAdministation.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdministation.Presenters.Enum
{
    public enum FilmInfo
    {
        DIRECTOR,
        OPERATOR,
        ACTOR,
        PRODUCTION,
        PRIZE,
        GENRE
    }

    public static class FilmInfoUtilGetter
    {
        public static Type GetServiceType(FilmInfo e)
        {
            switch(e)
            {
                case FilmInfo.DIRECTOR:
                    return typeof(DirectorService);
                case FilmInfo.OPERATOR:
                    return typeof(OperatorService);
                case FilmInfo.ACTOR:
                    return typeof(ActorService);
                case FilmInfo.GENRE:
                    return typeof(GenreService);
                case FilmInfo.PRIZE:
                    return typeof(PrizeService);
                case FilmInfo.PRODUCTION:
                    return typeof(ProductionService);
                default:
                    throw new ArgumentException("No such enumeration member exists");
            }
        }

        public static Type GetAddViewPresenterType(FilmInfo e)
        {
            switch(e)
            {
                case FilmInfo.DIRECTOR:
                    return typeof(AddDirectorViewPresenter);
                case FilmInfo.OPERATOR:
                    return typeof(AddOperatorViewPresenter);
                case FilmInfo.ACTOR:
                    return typeof(AddActorViewPresenter);
                case FilmInfo.GENRE:
                    return typeof(AddGenreViewPresenter);
                case FilmInfo.PRODUCTION:
                    return typeof(AddProductionViewPresenter);
                case FilmInfo.PRIZE:
                    return typeof(AddPrizeViewPresenter);
                default:
                    throw new ArgumentException("No such enumeration member exists");
            }
        }

        public static Type GetBaseViewModelType(FilmInfo e)
        {
            switch (e)
            {
                case FilmInfo.DIRECTOR:
                case FilmInfo.ACTOR:
                case FilmInfo.OPERATOR:
                    return typeof(BaseStaffViewModel);
                case FilmInfo.GENRE:
                case FilmInfo.PRIZE:
                case FilmInfo.PRODUCTION:
                    return typeof(BaseMetaViewModel);
                default:
                    throw new ArgumentException("No such enumeration member exists");
            }
        }

        public static Type GetListServiceType(FilmInfo e)
        {
            switch(e)
            {
                case (FilmInfo.ACTOR):
                    return typeof(ListOfActorsService);
                case (FilmInfo.DIRECTOR):
                    return typeof(ListOfDirectorsService);
                case (FilmInfo.OPERATOR):
                    return typeof(ListOfOperatorsService);
                case (FilmInfo.GENRE):
                    return typeof(ListOfGenresService);
                case (FilmInfo.PRIZE):
                    return typeof(ListOfPrizesService);
                case (FilmInfo.PRODUCTION):
                    return typeof(ListOfProductionsService);
                default:
                    throw new ArgumentException("No such enumeration member exists");
            }
        }

        public static BaseViewModel CreateListViewModel(FilmInfo e, FilmViewModel filmModel, object infoModel)
        {
            switch (e)
            {
                case (FilmInfo.ACTOR):
                    return new ListOfActorsViewModel
                    {
                        Film = filmModel,
                        Actor = (ActorViewModel) infoModel
                    };
                case (FilmInfo.DIRECTOR):
                    return new ListOfDirectorsViewModel
                    {
                        Film = filmModel,
                        Director = (DirectorViewModel)infoModel
                    };
                case (FilmInfo.OPERATOR):
                    return new ListOfOperatorsViewModel
                    {
                        Film = filmModel,
                        Operator = (OperatorViewModel)infoModel
                    };
                case (FilmInfo.GENRE):
                    return new ListOfGenersViewModel
                    {
                        Film = filmModel,
                        Genre = (GenreViewModel)infoModel
                    };
                case (FilmInfo.PRIZE):
                    return new ListOfPrizesViewModel
                    {
                        Film = filmModel,
                        Prize = (PrizeViewModel)infoModel
                    };
                case (FilmInfo.PRODUCTION):
                    return new ListOfProductionsViewModel
                    {
                        Film = filmModel,
                        Production = (ProductionViewModel)infoModel
                    };
                default:
                    throw new ArgumentException("No such enumeration member exists");
            }
        }
    }
}
