using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ContentBasedRS.Models
{
    public partial class Dim_StoreMapping
    {
        public long StoreMappingId { get; set; }
        public long StoreId { get; set; }
        public long? OrganizationId { get; set; }
        public long? StoreGroupingId { get; set; }
        public long? StoreStatusId { get; set; }
        public long? StoreTypeId { get; set; }
        public long? WardId { get; set; }
    }
}
