using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ContentBasedRS.Models
{
    public partial class Fact_StoreScouting
    {
        public long StoreScoutingId { get; set; }
        public string Code { get; set; }
        public long? OrganizationId { get; set; }
        public string Name { get; set; }
        public string OwnerPhone { get; set; }
        public long? WardId { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public long CreatorId { get; set; }
        public long StoreScoutingStatusId { get; set; }
        public long StoreScoutingTypeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long? ProvinceId { get; set; }
        public long? DistrictId { get; set; }
    }
}
