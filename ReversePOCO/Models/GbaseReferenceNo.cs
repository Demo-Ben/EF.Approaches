using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GbaseReferenceNo
    {
        public string DealTypeCode { get; set; }
        public decimal ReferenceCode { get; set; }
        public DateTime? Expiry { get; set; }
    }
}
