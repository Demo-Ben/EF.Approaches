using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class FuturesRate
    {
        public DateTime DataDate { get; set; }
        public string Ccy { get; set; }
        public DateTime Period { get; set; }
        public decimal Rate { get; set; }
        public string ImportedBy { get; set; }
        public string RecStatus { get; set; }
    }
}
