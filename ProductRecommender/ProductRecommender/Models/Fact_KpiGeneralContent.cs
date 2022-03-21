using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Fact_KpiGeneralContent
    {
        public long KpiGeneralContentId { get; set; }
        public long KpiGeneralId { get; set; }
        public long OrganizationId { get; set; }
        public long EmployeeId { get; set; }
        public long StatusId { get; set; }
        public long CreatorId { get; set; }
        public long KpiCriteriaGeneralId { get; set; }
        public long? YearId { get; set; }
        public long? QuarterId { get; set; }
        public long? MonthId { get; set; }
        public decimal? Value { get; set; }
    }
}
