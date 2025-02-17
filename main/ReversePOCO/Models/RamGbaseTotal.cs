using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class RamGbaseTotal
    {
        public DateTime ProcessDate { get; set; }
        public string Department { get; set; }
        public int Total { get; set; }
        public int? DeleteTotal { get; set; }
        public string Branch { get; set; }
    }
}
