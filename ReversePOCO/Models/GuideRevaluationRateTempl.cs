using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GuideRevaluationRateTempl
    {
        public string Ric { get; set; }
        public string Ccy { get; set; }
        public int Duration { get; set; }
        public int OrderBy { get; set; }
        public bool IsGbaseUpload { get; set; }
        public string MurexLable { get; set; }
        public string Type { get; set; }
        public string Generator { get; set; }
        public string Market { get; set; }
        public string Maturity { get; set; }
    }
}
