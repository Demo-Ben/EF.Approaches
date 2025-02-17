using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class ViewRatesGuideSwapRate
    {
        public string Ccy { get; set; }
        public int Duration { get; set; }
        public string DurationUnit { get; set; }
        public decimal? BidRate { get; set; }
        public decimal? OfferRate { get; set; }
        public int OrderBy { get; set; }
    }
}
