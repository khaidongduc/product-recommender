using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ContentBasedRS.Models
{
    public partial class Dim_Album
    {
        public long AlbumId { get; set; }
        public string Name { get; set; }
        public long StatusId { get; set; }
    }
}
