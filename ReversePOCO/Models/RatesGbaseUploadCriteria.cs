using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class RatesGbaseUploadCriteria
    {
        public string RateType { get; set; }
        public string Ccy { get; set; }
        public string CriteriaType { get; set; }
        public string AcuFlag { get; set; }
        public string BuFlag { get; set; }
    }
}
