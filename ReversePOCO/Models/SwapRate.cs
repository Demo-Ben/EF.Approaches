using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class SwapRate
    {
        public DateTime DataDate { get; set; }
        public string Ccy { get; set; }
        public int Duration { get; set; }
        public string DurationUnit { get; set; }
        public decimal BidRate { get; set; }
        public decimal OfferRate { get; set; }
        public string ImportedBy { get; set; }
        public string RecStatus { get; set; }
        public DateTime ImportedTime { get; set; }
    }
}
