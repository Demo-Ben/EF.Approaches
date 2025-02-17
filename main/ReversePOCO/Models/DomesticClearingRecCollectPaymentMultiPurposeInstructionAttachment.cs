using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachment
    {
        public int RecCollectPaymentMultiPurposeInstructionAttachment { get; set; }
        public int RecCollectionId { get; set; }
        public int? MultiPurposeInstructionAttachmentId { get; set; }
        public int? MultiPurposeInstructionDetailId { get; set; }
        public string CustomerName { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? Amount { get; set; }
        public string BeneficiaryName { get; set; }
        public string Bsb { get; set; }
        public string Account { get; set; }
        public string Reference { get; set; }
        public string CustomerCurrentAccount { get; set; }
        public bool? Processed { get; set; }
        public int? PaymentLineId { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime? CreatedWhen { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
