using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingPaymentValidationError
    {
        public int PaymentValidationErrorId { get; set; }
        public int? PaymentId { get; set; }
        public int? ValidationErrorId { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingPayment Payment { get; set; }
        public virtual DomesticClearingValidationError ValidationError { get; set; }
    }
}
