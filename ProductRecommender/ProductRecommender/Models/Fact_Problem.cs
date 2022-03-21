using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class Fact_Problem
    {
        public long ProblemId { get; set; }
        public string Code { get; set; }
        public long? StoreCheckingId { get; set; }
        public long StoreId { get; set; }
        public long CreatorId { get; set; }
        public long ProblemTypeId { get; set; }
        public DateTime NoteAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string Content { get; set; }
        public long ProblemStatusId { get; set; }
    }
}
