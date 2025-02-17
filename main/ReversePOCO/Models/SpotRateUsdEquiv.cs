using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class SpotRateUsdEquiv
    {
        public DateTime DataDate { get; set; }
        public string Ccy { get; set; }
        public decimal Rate { get; set; }
        public DateTime? ImportedTime { get; set; }
    }
}
