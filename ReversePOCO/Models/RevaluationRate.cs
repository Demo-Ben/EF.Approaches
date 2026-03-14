using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class RevaluationRate
    {
        public DateTime DataDate { get; set; }
        public string Ccy { get; set; }
        public int Days { get; set; }
        public decimal Rate { get; set; }
        public string ImportedBy { get; set; }
        public string RecStatus { get; set; }
        public string GbaseMsg { get; set; }
        public DateTime ImportedTime { get; set; }
    }
}
