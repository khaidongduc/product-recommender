using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ContentBasedRS.Models
{
    public partial class Dim_AddressMapping
    {
        public long AddressMappingId { get; set; }
        public long? WardId { get; set; }
        public long? DistrictId { get; set; }
        public long? ProvinceId { get; set; }
        public long? CountryId { get; set; }
    }
}
