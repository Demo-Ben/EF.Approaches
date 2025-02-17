using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollatePayment
    {
        public int RecCollatePaymentId { get; set; }
        public int RecCollectionId { get; set; }
        public int RecBatchId { get; set; }
        public string GcmsreferenceNumber { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? Amount { get; set; }
        public int? NumberOfTrans { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
