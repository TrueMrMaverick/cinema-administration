using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class Actor
    {
        public Actor()
        {
            ListOfActors = new HashSet<ListOfActors>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<ListOfActors> ListOfActors { get; set; }
    }
}