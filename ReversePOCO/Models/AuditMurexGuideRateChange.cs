using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class AuditMurexGuideRateChange
    {
        public int Identifier { get; set; }
        public DateTime? Logdate { get; set; }
        public string RateType { get; set; }
        public string Detail { get; set; }
    }
}
