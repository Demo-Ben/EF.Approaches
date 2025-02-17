using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingMultiPurposeInstructionDetail
    {
        public DomesticClearingMultiPurposeInstructionDetail()
        {
            DomesticClearingMultiPurposeInstructionAttachments = new HashSet<DomesticClearingMultiPurposeInstructionAttachment>();
        }

        public int MultiPurposeInstructionDetailId { get; set; }
        public string FileName { get; set; }
        public string GcmsreferenceNumber { get; set; }
        public string CustomerUnitCode { get; set; }
        public string CustomerUnitName { get; set; }
        public string Title { get; set; }
        public string TransactionMethod { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ValueDate { get; set; }
        public int? NumberofTransactions { get; set; }
        public string Attachment { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string RejectedReason { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public bool AttachmentDownloaded { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }

        public virtual DomesticClearingPayment Payment { get; set; }
        public virtual ICollection<DomesticClearingMultiPurposeInstructionAttachment> DomesticClearingMultiPurposeInstructionAttachments { get; set; }
    }
}
