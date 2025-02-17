using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class EucTaxCode
    {
        public string TaxId { get; set; }
        public string TaxCd { get; set; }
        public decimal? TaxRate { get; set; }
        public string BranchNo { get; set; }
    }
}
