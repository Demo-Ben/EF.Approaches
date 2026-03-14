using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollateInwardClearing
    {
        public int RecCollateInwardClearingId { get; set; }
        public int RecCollectionId { get; set; }
        public int RecBatchId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? Amount { get; set; }
        public int? Items { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
