using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class ViewRamReconSummary
    {
        public string Kind { get; set; }
        public string Ccy { get; set; }
        public int? GuideNos { get; set; }
        public decimal? GuideAmount { get; set; }
        public string GuideFormattedAmt { get; set; }
        public string RamTypeCode { get; set; }
        public int? GbaseTotal { get; set; }
        public string Department { get; set; }
        public string Branch { get; set; }
        public decimal? GbaseApprovedAmt { get; set; }
        public string GbaseFormattedAmt { get; set; }
        public int? GbaseDeleteTotal { get; set; }
        public int? FxalmCount { get; set; }
        public decimal? FxalmAmt { get; set; }
        public string FxalmFormattedAmt { get; set; }
        public string Comparerkey { get; set; }
        public string Comparefkey { get; set; }
    }
}
