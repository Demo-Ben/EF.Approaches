using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingPaymentMethod
    {
        public DomesticClearingPaymentMethod()
        {
            DomesticClearingFees = new HashSet<DomesticClearingFee>();
            DomesticClearingPayments = new HashSet<DomesticClearingPayment>();
        }

        public int PaymentMethodId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public int DirectionId { get; set; }
        public bool IsMultipurpose { get; set; }
        public string GbaseRefPrefix { get; set; }
        public string GasfileType { get; set; }
        public string Remarks { get; set; }
        public int SourceId { get; set; }
        public int Priority { get; set; }

        public virtual DomesticClearingDirection Direction { get; set; }
        public virtual DomesticClearingSource Source { get; set; }
        public virtual ICollection<DomesticClearingFee> DomesticClearingFees { get; set; }
        public virtual ICollection<DomesticClearingPayment> DomesticClearingPayments { get; set; }
    }
}
