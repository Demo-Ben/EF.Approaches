using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class ObsYieldRate
    {
        public int Id { get; set; }
        public string ObsCcy { get; set; }
        public string ObsYieldCurveType { get; set; }
        public string ObsYieldMaturity { get; set; }
        public decimal? Bid { get; set; }
        public decimal? Ask { get; set; }
        public decimal? Mid { get; set; }
        public DateTime? Date { get; set; }
    }
}
