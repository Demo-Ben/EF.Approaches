using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingPayment
    {
        public DomesticClearingPayment()
        {
            DomesticClearingBulkPaymentDetails = new HashSet<DomesticClearingBulkPaymentDetail>();
            DomesticClearingDeposits = new HashSet<DomesticClearingDeposit>();
            DomesticClearingDirectEntries = new HashSet<DomesticClearingDirectEntry>();
            DomesticClearingGdes = new HashSet<DomesticClearingGde>();
            DomesticClearingMultiPurposeInstructionDetails = new HashSet<DomesticClearingMultiPurposeInstructionDetail>();
            DomesticClearingPaymentLines = new HashSet<DomesticClearingPaymentLine>();
            DomesticClearingPaymentLogs = new HashSet<DomesticClearingPaymentLog>();
            DomesticClearingPaymentValidationErrors = new HashSet<DomesticClearingPaymentValidationError>();
            DomesticClearingPresentments = new HashSet<DomesticClearingPresentment>();
        }

        public int PaymentId { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Fees { get; set; }
        public string CurrencyCode { get; set; }
        public string CustomerCurrentAccount { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public int? StatusId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public string GcmsreferenceNumber { get; set; }
        public int? DirectionId { get; set; }
        public int? MainPostId { get; set; }
        public int? FeePostId { get; set; }
        public string CustomerAbbreviation { get; set; }
        public int? PaymentMethodId { get; set; }
        public string BranchNo { get; set; }
        public bool? IsClearerExtracted { get; set; }
        public string ClearerExtractFileName { get; set; }
        public string UnitCode { get; set; }
        public string AccountName { get; set; }
        public int? Lines { get; set; }
        public bool? IsValid { get; set; }
        public bool? IsPaymentGoposted { get; set; }
        public bool? IsFeeGoposted { get; set; }
        public bool? IsClearerReceived { get; set; }
        public string Bsb { get; set; }
        public DateTime? ProcessDate { get; set; }
        public DateTime? AvailableDate { get; set; }
        public string OriginalAccountName { get; set; }
        public int? ChequesCount { get; set; }
        public decimal? ChequesValue { get; set; }
        public decimal? CashValue { get; set; }
        public string ChequeNo { get; set; }
        public string Remark { get; set; }
        public int? PreviousStatusId { get; set; }
        public DateTime? LowPriorityWhen { get; set; }
        public int? ProductId { get; set; }
        public bool? IsDepartmentHandling { get; set; }
        public string DereplyFilename { get; set; }
        public string ChequeFrontImageName { get; set; }
        public string ChequeReverseImageName { get; set; }

        public virtual DomesticClearingDirection Direction { get; set; }
        public virtual DomesticClearingGoposting FeePost { get; set; }
        public virtual DomesticClearingGoposting MainPost { get; set; }
        public virtual DomesticClearingPaymentMethod PaymentMethod { get; set; }
        public virtual DomesticClearingProduct Product { get; set; }
        public virtual DomesticClearingStatu Status { get; set; }
        public virtual ICollection<DomesticClearingBulkPaymentDetail> DomesticClearingBulkPaymentDetails { get; set; }
        public virtual ICollection<DomesticClearingDeposit> DomesticClearingDeposits { get; set; }
        public virtual ICollection<DomesticClearingDirectEntry> DomesticClearingDirectEntries { get; set; }
        public virtual ICollection<DomesticClearingGde> DomesticClearingGdes { get; set; }
        public virtual ICollection<DomesticClearingMultiPurposeInstructionDetail> DomesticClearingMultiPurposeInstructionDetails { get; set; }
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLines { get; set; }
        public virtual ICollection<DomesticClearingPaymentLog> DomesticClearingPaymentLogs { get; set; }
        public virtual ICollection<DomesticClearingPaymentValidationError> DomesticClearingPaymentValidationErrors { get; set; }
        public virtual ICollection<DomesticClearingPresentment> DomesticClearingPresentments { get; set; }
    }
}
