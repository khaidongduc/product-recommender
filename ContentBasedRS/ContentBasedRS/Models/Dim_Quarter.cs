using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ContentBasedRS.Models
{
    public partial class Dim_Quarter
    {
        public long QuarterId { get; set; }
        public long Quarter { get; set; }
        public long Year { get; set; }
    }
}
