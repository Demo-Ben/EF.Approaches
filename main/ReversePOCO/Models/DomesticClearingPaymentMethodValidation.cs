using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingPaymentMethodValidation
    {
        public int PaymentMethodValidationId { get; set; }
        public int PaymentMethodId { get; set; }
        public int ValidationErrorId { get; set; }
        public int? ReturnRefusalCodeId { get; set; }
        public int? Priority { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime? CreatedWhen { get; set; }
    }
}
