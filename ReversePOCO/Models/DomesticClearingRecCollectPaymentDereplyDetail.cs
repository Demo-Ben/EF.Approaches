using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectPaymentDereplyDetail
    {
        public int RecCollectPaymentDereplyDetailId { get; set; }
        public int RecCollectionId { get; set; }
        public string RecordType { get; set; }
        public string SequenceNumber { get; set; }
        public string Bsbnumber { get; set; }
        public string AccountNumberDebitCredit { get; set; }
        public string Indicator { get; set; }
        public string TransactionCode { get; set; }
        public decimal? Amount { get; set; }
        public string TitleOfAccountCreditedDebited { get; set; }
        public string LodgementReference { get; set; }
        public string TraceBsbNumber { get; set; }
        public string TraceAccountNumber { get; set; }
        public string RemitterName { get; set; }
        public decimal? WithholdingTaxAmount { get; set; }
        public string StatusCode { get; set; }
        public string StatusText { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
