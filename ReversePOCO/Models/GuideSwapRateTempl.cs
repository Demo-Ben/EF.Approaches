using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GuideSwapRateTempl
    {
        public string Ric { get; set; }
        public string Ccy { get; set; }
        public int Duration { get; set; }
        public string DurationUnit { get; set; }
        public int OrderBy { get; set; }
    }
}
