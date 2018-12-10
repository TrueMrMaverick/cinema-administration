using System;
using System.Collections.Generic;

namespace HotelAdministation.Models
{
    public partial class DbLog
    {
        public long Id { get; set; }
        public string TableName { get; set; }
        public long? RowId { get; set; }
        public string TriggerName { get; set; }
        public string Action { get; set; }
        public DateTime? Date { get; set; }
    }
}
