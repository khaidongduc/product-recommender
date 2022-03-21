using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ContentBasedRS.Models
{
    public partial class Fact_StoreHistory
    {
        public long StoreHistoryId { get; set; }
        public long StoreId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long? AppUserId { get; set; }
        public long StatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long StoreStatusId { get; set; }
        public long? EstimatedRevenueId { get; set; }
    }
}
