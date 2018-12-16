using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.ViewModels
{
    public class ListOfGenersViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public FilmViewModel Film { get; set; }
        public GenreViewModel Genre { get; set; }
    }
}