using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectGoGoposting
    {
        public int RecCollectGogopostingId { get; set; }
        public int RecCollectionId { get; set; }
        public int? GopostingId { get; set; }
        public string GbaseRefNo { get; set; }
        public string TransNo { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Adjustment { get; set; }
        public string CurrencyCode { get; set; }
        public string Remark { get; set; }
        public string DebitAccountCode { get; set; }
        public string DebitAccountNo { get; set; }
        public string CreditAccountCode { get; set; }
        public string CreditAccountNo { get; set; }
        public string DebitCustomerAbbreviation { get; set; }
        public string CreditCustomerAbbreviation { get; set; }
        public int? DirectionId { get; set; }
        public bool? NeedsAutomaticApproval { get; set; }
        public string CreditMinNo { get; set; }
        public string DebitMinNo { get; set; }
        public int? PaymentId { get; set; }
        public int? StatusId { get; set; }
        public int? PostingTypeId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public DateTime? OperationDate { get; set; }
        public int? PaymentLineId { get; set; }
        public string BranchNo { get; set; }
        public DateTime CreatedWhen { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
