using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Fact_BrandHistory
    {
        public long BrandHistoryId { get; set; }
        public long BrandId { get; set; }
        public long? AppUserId { get; set; }
        public long StatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? Used { get; set; }
    }
}
