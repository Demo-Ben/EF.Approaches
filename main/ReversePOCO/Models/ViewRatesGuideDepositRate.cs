using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class ViewRatesGuideDepositRate
    {
        public string Ccy { get; set; }
        public string Period { get; set; }
        public decimal? Rate { get; set; }
        public int OrderBy { get; set; }
    }
}
