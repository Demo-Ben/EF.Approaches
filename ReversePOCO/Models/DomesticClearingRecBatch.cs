using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecBatch
    {
        public DomesticClearingRecBatch()
        {
            DomesticClearingRecCollateGoes = new HashSet<DomesticClearingRecCollateGo>();
            DomesticClearingRecCollateInwardClearings = new HashSet<DomesticClearingRecCollateInwardClearing>();
            DomesticClearingRecCollatePaymentCreations = new HashSet<DomesticClearingRecCollatePaymentCreation>();
            DomesticClearingRecCollatePayments = new HashSet<DomesticClearingRecCollatePayment>();
            DomesticClearingRecRecGoes = new HashSet<DomesticClearingRecRecGo>();
            DomesticClearingRecRecInwardClearings = new HashSet<DomesticClearingRecRecInwardClearing>();
            DomesticClearingRecRecPaymentCreations = new HashSet<DomesticClearingRecRecPaymentCreation>();
            DomesticClearingRecRecPayments = new HashSet<DomesticClearingRecRecPayment>();
        }

        public int RecBatchId { get; set; }
        public int RecTypeId { get; set; }
        public DateTime? ValueDateFrom { get; set; }
        public DateTime? ValueDateTo { get; set; }
        public DateTime? CreationDateFrom { get; set; }
        public DateTime? CreationDateTo { get; set; }
        public DateTime? OperationDateFrom { get; set; }
        public DateTime? OperationDateTo { get; set; }
        public bool Processed { get; set; }
        public bool Completed { get; set; }
        public bool? SentClearer { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public DateTime? ProcessingDateFrom { get; set; }
        public DateTime? ProcessingDateTo { get; set; }

        public virtual DomesticClearingRecType RecType { get; set; }
        public virtual ICollection<DomesticClearingRecCollateGo> DomesticClearingRecCollateGoes { get; set; }
        public virtual ICollection<DomesticClearingRecCollateInwardClearing> DomesticClearingRecCollateInwardClearings { get; set; }
        public virtual ICollection<DomesticClearingRecCollatePaymentCreation> DomesticClearingRecCollatePaymentCreations { get; set; }
        public virtual ICollection<DomesticClearingRecCollatePayment> DomesticClearingRecCollatePayments { get; set; }
        public virtual ICollection<DomesticClearingRecRecGo> DomesticClearingRecRecGoes { get; set; }
        public virtual ICollection<DomesticClearingRecRecInwardClearing> DomesticClearingRecRecInwardClearings { get; set; }
        public virtual ICollection<DomesticClearingRecRecPaymentCreation> DomesticClearingRecRecPaymentCreations { get; set; }
        public virtual ICollection<DomesticClearingRecRecPayment> DomesticClearingRecRecPayments { get; set; }
    }
}
