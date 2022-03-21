using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class View_KPIDoanhThu
    {
        public int? Month1 { get; set; }
        public int? Year1 { get; set; }
        public string Province { get; set; }
        public string KPI { get; set; }
        public decimal? Revenue { get; set; }
    }
}
