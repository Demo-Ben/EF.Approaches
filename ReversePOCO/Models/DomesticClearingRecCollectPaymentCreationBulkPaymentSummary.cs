using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectPaymentCreationBulkPaymentSummary
    {
        public int RecCollectPaymentCreationBulkPaymentSummaryId { get; set; }
        public int RecCollectionId { get; set; }
        public int? BulkPaymentSummaryId { get; set; }
        public string GcmsreferenceNumber { get; set; }
        public string CustomerUnitCode { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string TransactionStatusType { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Approver1 { get; set; }
        public DateTime? ApproveDate1 { get; set; }
        public string Approver2 { get; set; }
        public DateTime? ApproveDate2 { get; set; }
        public string Approver3 { get; set; }
        public DateTime? ApproveDate3 { get; set; }
        public string Approver4 { get; set; }
        public DateTime? ApproveDate4 { get; set; }
        public string Approver5 { get; set; }
        public DateTime? ApproveDate5 { get; set; }
        public string DebitAccountNumber { get; set; }
        public string Remarks { get; set; }
        public string RejectionFlag { get; set; }
        public string DecimalPointSymbol { get; set; }
        public string DateFormat { get; set; }
        public DateTime? ValueDate { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string BulkTransactionFormatDefinitionName { get; set; }
        public string ReferenceAuthority { get; set; }
        public int? TotalNumberofTrans { get; set; }
        public int? StatusId { get; set; }
        public DateTime? BulkPaymentSummaryCreatedWhen { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
