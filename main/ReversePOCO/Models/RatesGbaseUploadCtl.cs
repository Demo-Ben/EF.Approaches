using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class RatesGbaseUploadCtl
    {
        public string RateType { get; set; }
        public DateTime OprDate { get; set; }
        public string Ccy { get; set; }
        public string UploadedBy { get; set; }
        public string AcuStatus { get; set; }
        public string BuStatus { get; set; }
        public string GbaseMsg { get; set; }
        public string AcuTransStatus { get; set; }
        public string BuTransStatus { get; set; }
    }
}
