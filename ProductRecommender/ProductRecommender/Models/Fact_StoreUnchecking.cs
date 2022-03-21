using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Fact_StoreUnchecking
    {
        public long StoreUncheckingId { get; set; }
        public long OrganizationId { get; set; }
        public long AppUserId { get; set; }
        public long StoreId { get; set; }
        public DateTime Date { get; set; }
    }
}
