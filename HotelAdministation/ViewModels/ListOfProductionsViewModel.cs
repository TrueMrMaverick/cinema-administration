using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.ViewModels
{
    public class ListOfProductionsViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public FilmViewModel Film { get; set; }
        public ProductionViewModel Production { get; set; }
    }
}