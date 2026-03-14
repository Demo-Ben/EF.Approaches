using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingReturnRefusalCode
    {
        public DomesticClearingReturnRefusalCode()
        {
            DomesticClearingPaymentLines = new HashSet<DomesticClearingPaymentLine>();
        }

        public int ReturnRefusalCodeId { get; set; }
        public int? ReturnCode { get; set; }
        public int? RefusalCode { get; set; }
        public int? FailureCode { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public bool IsPresentment { get; set; }

        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLines { get; set; }
    }
}
