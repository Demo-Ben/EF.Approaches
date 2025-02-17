using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingValidationError
    {
        public DomesticClearingValidationError()
        {
            DomesticClearingPaymentLineValidationErrors = new HashSet<DomesticClearingPaymentLineValidationError>();
            DomesticClearingPaymentValidationErrors = new HashSet<DomesticClearingPaymentValidationError>();
        }

        public int ValidationErrorId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsInternal { get; set; }
        public bool IsVerfiable { get; set; }
        public bool IsPreError { get; set; }
        public bool IsReturn { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual ICollection<DomesticClearingPaymentLineValidationError> DomesticClearingPaymentLineValidationErrors { get; set; }
        public virtual ICollection<DomesticClearingPaymentValidationError> DomesticClearingPaymentValidationErrors { get; set; }
    }
}
