using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Dim_ShowingItemMapping
    {
        public long ShowingItemMappingId { get; set; }
        public long? ShowingItemId { get; set; }
        public long? UnitOfMeasureId { get; set; }
        public long? ProductGroupingId { get; set; }
        public long? ProductTypeId { get; set; }
        public long? CategoryId { get; set; }
        public long? BrandId { get; set; }
        public long? SupplierId { get; set; }
    }
}
