using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingPaymentLine
    {
        public DomesticClearingPaymentLine()
        {
            DomesticClearingBulkPaymentDetails = new HashSet<DomesticClearingBulkPaymentDetail>();
            DomesticClearingDirectEntries = new HashSet<DomesticClearingDirectEntry>();
            DomesticClearingGdes = new HashSet<DomesticClearingGde>();
            DomesticClearingGopostings = new HashSet<DomesticClearingGoposting>();
            DomesticClearingMultiPurposeInstructionAttachments = new HashSet<DomesticClearingMultiPurposeInstructionAttachment>();
            DomesticClearingPaymentLineValidationErrors = new HashSet<DomesticClearingPaymentLineValidationError>();
        }

        public int PaymentLineId { get; set; }
        public int PaymentId { get; set; }
        public decimal? Amount { get; set; }
        public string BeneficiaryName { get; set; }
        public string Bsb { get; set; }
        public string Account { get; set; }
        public string Reference { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public int? StatusId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? ReturnRefusalCodeId { get; set; }
        public decimal? ReturnFee { get; set; }
        public int? ReturnPostId { get; set; }
        public int? ReturnFeePostId { get; set; }

        public virtual DomesticClearingPayment Payment { get; set; }
        public virtual DomesticClearingGoposting ReturnFeePost { get; set; }
        public virtual DomesticClearingGoposting ReturnPost { get; set; }
        public virtual DomesticClearingReturnRefusalCode ReturnRefusalCode { get; set; }
        public virtual DomesticClearingStatu Status { get; set; }
        public virtual ICollection<DomesticClearingBulkPaymentDetail> DomesticClearingBulkPaymentDetails { get; set; }
        public virtual ICollection<DomesticClearingDirectEntry> DomesticClearingDirectEntries { get; set; }
        public virtual ICollection<DomesticClearingGde> DomesticClearingGdes { get; set; }
        public virtual ICollection<DomesticClearingGoposting> DomesticClearingGopostings { get; set; }
        public virtual ICollection<DomesticClearingMultiPurposeInstructionAttachment> DomesticClearingMultiPurposeInstructionAttachments { get; set; }
        public virtual ICollection<DomesticClearingPaymentLineValidationError> DomesticClearingPaymentLineValidationErrors { get; set; }
    }
}
