using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxTaxCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal? TaxRate { get; set; }
        public string Description { get; set; }
        public string Branch { get; set; }
    }
}
