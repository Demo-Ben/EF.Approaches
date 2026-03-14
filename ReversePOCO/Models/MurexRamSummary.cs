using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MurexRamSummary
    {
        public string Kind { get; set; }
        public string Ccy { get; set; }
        public int Nos { get; set; }
        public decimal Amount { get; set; }
    }
}
