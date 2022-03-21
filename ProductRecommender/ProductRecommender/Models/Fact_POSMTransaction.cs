using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Fact_POSMTransaction
    {
        public long Id { get; set; }
        public long ShowingOrderId { get; set; }
        public long OrganizationId { get; set; }
        public long AppUserId { get; set; }
        public long StoreId { get; set; }
        public long ShowingItemId { get; set; }
        public long Quantity { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal Amount { get; set; }
        public long TransactionTypeId { get; set; }
    }
}
