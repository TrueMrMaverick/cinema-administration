using System;
using System.Collections.Generic;

namespace HotelAdministation.NewModels
{
    public partial class Director
    {
        public Director()
        {
            ListOfDirectors = new HashSet<ListOfDirectors>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<ListOfDirectors> ListOfDirectors { get; set; }
    }
}
