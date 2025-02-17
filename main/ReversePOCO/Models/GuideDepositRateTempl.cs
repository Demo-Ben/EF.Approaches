using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GuideDepositRateTempl
    {
        public string Ric { get; set; }
        public string Ccy { get; set; }
        public string Period { get; set; }
        public int OrderBy { get; set; }
    }
}
