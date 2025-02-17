using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class Status
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ShortDes { get; set; }
        public string Description { get; set; }
    }
}
