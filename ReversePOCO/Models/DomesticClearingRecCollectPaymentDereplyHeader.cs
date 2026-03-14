using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectPaymentDereplyHeader
    {
        public int RecCollectPaymentDereplyHeaderId { get; set; }
        public int RecCollectionId { get; set; }
        public string RecordType { get; set; }
        public string PaymentReferenceNumber { get; set; }
        public string Bsbnumber { get; set; }
        public string AccountNumberDebitCredit { get; set; }
        public string DateTimeProcessed { get; set; }
        public string ReportingMethod { get; set; }
        public string UserIdNumber { get; set; }
        public string EntriesDescription { get; set; }
        public string DateToBeProcessed { get; set; }
        public string CustomerReference { get; set; }
        public string PendingAuthorisation { get; set; }
        public string FailReasonCode { get; set; }
        public string FailReasonText { get; set; }
        public int? NumberOfValidItems { get; set; }
        public int? NumberOfItemsFailed { get; set; }
        public decimal? CreditTotalsOfValidItems { get; set; }
        public decimal? DebitTotalsOfValidItems { get; set; }
        public decimal? CreditTotalsOfFailedItems { get; set; }
        public decimal? DebitTotalsOfFailedItems { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
