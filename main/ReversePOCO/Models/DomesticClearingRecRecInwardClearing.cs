using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecRecInwardClearing
    {
        public int RecRecInwardClearingId { get; set; }
        public int RecBatchId { get; set; }
        public string PaymentMethod { get; set; }
        public int? PmtRecCollateInwardClearingId { get; set; }
        public int? ClrRecCollateInwardClearingId { get; set; }
        public decimal? PmtAmount { get; set; }
        public decimal? ClrAmount { get; set; }
        public int? PmtItems { get; set; }
        public int? ClrItems { get; set; }
        public int? RecKeyStatusId { get; set; }
        public int? RecValueStatusId { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        public virtual DomesticClearingRecKeyStatu RecKeyStatus { get; set; }
        public virtual DomesticClearingRecValueStatu RecValueStatus { get; set; }
    }
}
