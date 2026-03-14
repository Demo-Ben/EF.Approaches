using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingDirectEntry
    {
        public int DirectEntryId { get; set; }
        public DateTime? DateToBeProcessed { get; set; }
        public string Bsbnumber { get; set; }
        public string AccountNumberToBeCreditedDebited { get; set; }
        public string Indicator { get; set; }
        public string TrasactionCode { get; set; }
        public decimal? Amount { get; set; }
        public string TitleOfAccountCreditedDebited { get; set; }
        public string LodgementReference { get; set; }
        public string TraceRecordBsb { get; set; }
        public string TraceRecordAccountNumber { get; set; }
        public string RemitterName { get; set; }
        public decimal? WithHoldingTaxAmount { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        public int? PaymentLineId { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public DateTime CreatedWhen { get; set; }
        public string Filename { get; set; }
        public string NumberOfUserSupplyingFile { get; set; }

        public virtual DomesticClearingPayment Payment { get; set; }
        public virtual DomesticClearingPaymentLine PaymentLine { get; set; }
    }
}
