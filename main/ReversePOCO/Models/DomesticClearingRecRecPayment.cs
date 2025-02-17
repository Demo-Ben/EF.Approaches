using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecRecPayment
    {
        public int RecRecPaymentId { get; set; }
        public int RecBatchId { get; set; }
        public int? GebRecCollatePaymentId { get; set; }
        public int? PmtRecCollatePaymentId { get; set; }
        public int? ClrRecCollatePaymentId { get; set; }
        public string GcmsreferenceNumber { get; set; }
        public DateTime? GebValueDate { get; set; }
        public DateTime? PmtValueDate { get; set; }
        public DateTime? ClrValueDate { get; set; }
        public decimal? GebAmount { get; set; }
        public decimal? PmtAmount { get; set; }
        public decimal? ClrAmount { get; set; }
        public int? GebNumberOfTrans { get; set; }
        public int? PmtNumberOfTrans { get; set; }
        public int? ClrNumberOfTrans { get; set; }
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
