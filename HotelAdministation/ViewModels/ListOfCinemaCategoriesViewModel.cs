using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.ViewModels
{
    public class ListOfCinemaCategoriesViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public CinemaViewModel Cinema { get; set; }
        public CinemaCategoryViewModel CinemaCategory { get; set; }
    }
}