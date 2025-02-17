using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class BisRate
    {
        public DateTime DataDate { get; set; }
        public string Ccy { get; set; }
        public int Duration { get; set; }
        public string DurationUnit { get; set; }
        public decimal BaseRate { get; set; }
        public string ImportedBy { get; set; }
        public string RecStatus { get; set; }
        public DateTime ImportedTime { get; set; }
    }
}
