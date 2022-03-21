using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Fact_StoreStatusHistory
    {
        public long StoreStatusHistoryId { get; set; }
        public long StoreId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long AppUserId { get; set; }
        public long? PreviousStoreStatusId { get; set; }
        public long StoreStatusId { get; set; }
        public DateTime? PreviousCreatedAt { get; set; }
    }
}
