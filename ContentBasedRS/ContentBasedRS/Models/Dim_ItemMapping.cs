using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ContentBasedRS.Models
{
    public partial class Dim_ItemMapping
    {
        public long ItemMappingId { get; set; }
        public long ItemId { get; set; }
        public long? ProductId { get; set; }
        public long? ProductGroupingId { get; set; }
        public long? ProductTypeId { get; set; }
        public long? UnitOfMeasureId { get; set; }
        public long? CategoryId { get; set; }
        public long? BrandId { get; set; }
        public long? SupplierId { get; set; }
    }
}
