using HotelAdministation.ViewModels.Base;

namespace HotelAdministation.ViewModels
{
    public class ListOfAreasViewModel: BaseViewModel
    {
        public override long Id { get; set; }
        public CinemaViewModel Cinema { get; set; }
        public AreaViewModel Area { get; set; }
    }
}