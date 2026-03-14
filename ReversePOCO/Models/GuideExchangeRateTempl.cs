using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GuideExchangeRateTempl
    {
        public string Ccy { get; set; }
        public string MurexLable { get; set; }
        public bool? Direction { get; set; }
    }
}
