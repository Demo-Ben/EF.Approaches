using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingGoposting
    {
        public DomesticClearingGoposting()
        {
            DomesticClearingPaymentLineReturnFeePosts = new HashSet<DomesticClearingPaymentLine>();
            DomesticClearingPaymentLineReturnPosts = new HashSet<DomesticClearingPaymentLine>();
        }

        public int GopostingId { get; set; }
        public string GbaseRefNo { get; set; }
        public string TransNo { get; set; }
        public DateTime ValueDate { get; set; }
        public decimal Amount { get; set; }
        public decimal? Adjustment { get; set; }
        public string CurrencyCode { get; set; }
        public string Remark { get; set; }
        public string DebitAccountCode { get; set; }
        public string DebitAccountNo { get; set; }
        public string CreditAccountCode { get; set; }
        public string CreditAccountNo { get; set; }
        public string DebitCustomerAbbreviation { get; set; }
        public string CreditCustomerAbbreviation { get; set; }
        public int DirectionId { get; set; }
        public string CreditMinNo { get; set; }
        public string DebitMinNo { get; set; }
        public int? StatusId { get; set; }
        public int PostingTypeId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public DateTime? OperationDate { get; set; }
        public int? PaymentLineId { get; set; }
        public string BranchNo { get; set; }
        public string FileType { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public DateTime? ProcessDate { get; set; }
        public DateTime? AvailableDate { get; set; }
        public string ChequeNo { get; set; }
        public string GasDescription { get; set; }
        public int? PreviousStatusId { get; set; }

        public virtual GasGoDebit DebitMinNoNavigation { get; set; }
        public virtual DomesticClearingDirection Direction { get; set; }
        public virtual DomesticClearingPaymentLine PaymentLine { get; set; }
        public virtual DomesticClearingPostingType PostingType { get; set; }
        public virtual DomesticClearingGasStatu Status { get; set; }
        public virtual DomesticClearingPayment DomesticClearingPaymentFeePost { get; set; }
        public virtual DomesticClearingPayment DomesticClearingPaymentMainPost { get; set; }
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLineReturnFeePosts { get; set; }
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLineReturnPosts { get; set; }
    }
}
