using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Dim_Date
    {
        public long DateId { get; set; }
        public DateTime Date { get; set; }
        public long Day { get; set; }
        public string DayOfWeekName { get; set; }
        public long DayOfWeek { get; set; }
        public long DayOfYear { get; set; }
    }
}
