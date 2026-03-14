using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class CcyCodeTable
    {
        public string CcyCd { get; set; }
        public string CcyAbbr { get; set; }
        public short? DecimalPoint { get; set; }
        public string SetpsCd { get; set; }
        public string Mark3Cd { get; set; }
        public string SwiftCd { get; set; }
        public decimal? DkbSpecialRateUsd { get; set; }
        public decimal? DkbSpecialRateJpy { get; set; }
        public string BranchNo { get; set; }
    }
}
