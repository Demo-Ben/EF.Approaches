using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class FxRate
    {
        public DateTime DataDate { get; set; }
        public string Ccy { get; set; }
        public decimal Bid { get; set; }
        public decimal Offer { get; set; }
        public decimal Rate { get; set; }
        public string ImportedBy { get; set; }
        public string RecStatus { get; set; }
        public DateTime? ImportedTime { get; set; }
    }
}
