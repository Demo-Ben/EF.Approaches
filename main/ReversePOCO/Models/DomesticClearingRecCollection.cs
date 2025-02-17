using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollection
    {
        public DomesticClearingRecCollection()
        {
            DomesticClearingRecCollateGoes = new HashSet<DomesticClearingRecCollateGo>();
            DomesticClearingRecCollateInwardClearings = new HashSet<DomesticClearingRecCollateInwardClearing>();
            DomesticClearingRecCollatePaymentCreations = new HashSet<DomesticClearingRecCollatePaymentCreation>();
            DomesticClearingRecCollatePayments = new HashSet<DomesticClearingRecCollatePayment>();
            DomesticClearingRecCollectGoEuconDemandLogAccounts = new HashSet<DomesticClearingRecCollectGoEuconDemandLogAccount>();
            DomesticClearingRecCollectGoEuconDemandLogCommons = new HashSet<DomesticClearingRecCollectGoEuconDemandLogCommon>();
            DomesticClearingRecCollectGoGasGoCredits = new HashSet<DomesticClearingRecCollectGoGasGoCredit>();
            DomesticClearingRecCollectGoGasGoDebits = new HashSet<DomesticClearingRecCollectGoGasGoDebit>();
            DomesticClearingRecCollectGoGopostings = new HashSet<DomesticClearingRecCollectGoGoposting>();
            DomesticClearingRecCollectInwardClearingAnzSummaries = new HashSet<DomesticClearingRecCollectInwardClearingAnzSummary>();
            DomesticClearingRecCollectInwardClearingPayments = new HashSet<DomesticClearingRecCollectInwardClearingPayment>();
            DomesticClearingRecCollectPaymentBulkPaymentSummaries = new HashSet<DomesticClearingRecCollectPaymentBulkPaymentSummary>();
            DomesticClearingRecCollectPaymentCreationBulkPaymentSummaries = new HashSet<DomesticClearingRecCollectPaymentCreationBulkPaymentSummary>();
            DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachments = new HashSet<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachment>();
            DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetails = new HashSet<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetail>();
            DomesticClearingRecCollectPaymentCreationPayments = new HashSet<DomesticClearingRecCollectPaymentCreationPayment>();
            DomesticClearingRecCollectPaymentDereplyDetails = new HashSet<DomesticClearingRecCollectPaymentDereplyDetail>();
            DomesticClearingRecCollectPaymentDereplyHeaders = new HashSet<DomesticClearingRecCollectPaymentDereplyHeader>();
            DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachments = new HashSet<DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachment>();
            DomesticClearingRecCollectPaymentMultiPurposeInstructionDetails = new HashSet<DomesticClearingRecCollectPaymentMultiPurposeInstructionDetail>();
            DomesticClearingRecCollectPaymentPayments = new HashSet<DomesticClearingRecCollectPaymentPayment>();
        }

        public int RecCollectionId { get; set; }
        public int RecSourceId { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecSource RecSource { get; set; }
        public virtual ICollection<DomesticClearingRecCollateGo> DomesticClearingRecCollateGoes { get; set; }
        public virtual ICollection<DomesticClearingRecCollateInwardClearing> DomesticClearingRecCollateInwardClearings { get; set; }
        public virtual ICollection<DomesticClearingRecCollatePaymentCreation> DomesticClearingRecCollatePaymentCreations { get; set; }
        public virtual ICollection<DomesticClearingRecCollatePayment> DomesticClearingRecCollatePayments { get; set; }
        public virtual ICollection<DomesticClearingRecCollectGoEuconDemandLogAccount> DomesticClearingRecCollectGoEuconDemandLogAccounts { get; set; }
        public virtual ICollection<DomesticClearingRecCollectGoEuconDemandLogCommon> DomesticClearingRecCollectGoEuconDemandLogCommons { get; set; }
        public virtual ICollection<DomesticClearingRecCollectGoGasGoCredit> DomesticClearingRecCollectGoGasGoCredits { get; set; }
        public virtual ICollection<DomesticClearingRecCollectGoGasGoDebit> DomesticClearingRecCollectGoGasGoDebits { get; set; }
        public virtual ICollection<DomesticClearingRecCollectGoGoposting> DomesticClearingRecCollectGoGopostings { get; set; }
        public virtual ICollection<DomesticClearingRecCollectInwardClearingAnzSummary> DomesticClearingRecCollectInwardClearingAnzSummaries { get; set; }
        public virtual ICollection<DomesticClearingRecCollectInwardClearingPayment> DomesticClearingRecCollectInwardClearingPayments { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentBulkPaymentSummary> DomesticClearingRecCollectPaymentBulkPaymentSummaries { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentCreationBulkPaymentSummary> DomesticClearingRecCollectPaymentCreationBulkPaymentSummaries { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachment> DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachments { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetail> DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetails { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentCreationPayment> DomesticClearingRecCollectPaymentCreationPayments { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentDereplyDetail> DomesticClearingRecCollectPaymentDereplyDetails { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentDereplyHeader> DomesticClearingRecCollectPaymentDereplyHeaders { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachment> DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachments { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentMultiPurposeInstructionDetail> DomesticClearingRecCollectPaymentMultiPurposeInstructionDetails { get; set; }
        public virtual ICollection<DomesticClearingRecCollectPaymentPayment> DomesticClearingRecCollectPaymentPayments { get; set; }
    }
}
