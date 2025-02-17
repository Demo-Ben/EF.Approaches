using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingDeposit
    {
        public int DepositId { get; set; }
        public bool Processed { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public int? PaymentId { get; set; }
        public string Filename { get; set; }
        public DateTime? TransmissionDate { get; set; }
        public decimal? DepositValue { get; set; }
        public string AccountNumber { get; set; }
        public string DomicileBsb { get; set; }
        public string OriginalBsb { get; set; }
        public int? ChequesCount { get; set; }
        public decimal? ChequesValue { get; set; }
        public decimal? CashValue { get; set; }

        public virtual DomesticClearingPayment Payment { get; set; }
    }
}
