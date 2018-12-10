using System;
using System.Collections.Generic;

namespace HotelAdministation.NewModels
{
    public partial class Film
    {
        public Film()
        {
            ListOfActors = new HashSet<ListOfActors>();
            ListOfDirectors = new HashSet<ListOfDirectors>();
            ListOfOperators = new HashSet<ListOfOperators>();
            ListOfPrizes = new HashSet<ListOfPrizes>();
            Seance = new HashSet<Seance>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public string Image { get; set; }
        public int RentalPrice { get; set; }

        public ICollection<ListOfActors> ListOfActors { get; set; }
        public ICollection<ListOfDirectors> ListOfDirectors { get; set; }
        public ICollection<ListOfOperators> ListOfOperators { get; set; }
        public ICollection<ListOfPrizes> ListOfPrizes { get; set; }
        public ICollection<Seance> Seance { get; set; }
    }
}
