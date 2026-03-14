using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingPaymentLineValidationError
    {
        public int PaymentLineValidationErrorId { get; set; }
        public int? PaymentLineId { get; set; }
        public int? ValidationErrorId { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingPaymentLine PaymentLine { get; set; }
        public virtual DomesticClearingValidationError ValidationError { get; set; }
    }
}
