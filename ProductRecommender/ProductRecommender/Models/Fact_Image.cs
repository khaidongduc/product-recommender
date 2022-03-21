using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Fact_Image
    {
        public long ImageId { get; set; }
        public long? StoreCheckingId { get; set; }
        public long AlbumId { get; set; }
        public long StoreId { get; set; }
        public DateTime ShootingAt { get; set; }
        public long? SaleEmployeeId { get; set; }
        public long? Distance { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Url { get; set; }
        public long? OrganizationId { get; set; }
    }
}
