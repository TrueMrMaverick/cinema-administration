using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Genre
    {
        public Genre()
        {
            ListOfGenres = new HashSet<ListOfGenres>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ListOfGenres> ListOfGenres { get; set; }
    }
}