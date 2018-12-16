using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Film
    {
        public Film()
        {
            ListOfActors = new HashSet<ListOfActors>();
            ListOfDirectors = new HashSet<ListOfDirectors>();
            ListOfGenres = new HashSet<ListOfGenres>();
            ListOfOperators = new HashSet<ListOfOperators>();
            ListOfPrizes = new HashSet<ListOfPrizes>();
            ListOfProductions = new HashSet<ListOfProductions>();
            Seance = new HashSet<Seance>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public string Image { get; set; }
        public int RentalPrice { get; set; }

        public ICollection<ListOfActors> ListOfActors { get; set; }
        public ICollection<ListOfDirectors> ListOfDirectors { get; set; }
        public ICollection<ListOfGenres> ListOfGenres { get; set; }
        public ICollection<ListOfOperators> ListOfOperators { get; set; }
        public ICollection<ListOfPrizes> ListOfPrizes { get; set; }
        public ICollection<ListOfProductions> ListOfProductions { get; set; }
        public ICollection<Seance> Seance { get; set; }
    }
}