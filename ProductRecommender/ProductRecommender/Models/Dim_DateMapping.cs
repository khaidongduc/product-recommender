using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Dim_DateMapping
    {
        public long DateMappingId { get; set; }
        public DateTime Date { get; set; }
        public long DateId { get; set; }
        public long MonthId { get; set; }
        public long QuarterId { get; set; }
        public long YearId { get; set; }
    }
}
