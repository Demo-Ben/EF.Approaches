using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecRecPaymentCreation
    {
        public int RecRecPaymentCreationId { get; set; }
        public int RecBatchId { get; set; }
        public int? GebRecCollatePaymentCreationId { get; set; }
        public int? PmtRecCollatePaymentCreationId { get; set; }
        public string GcmsreferenceNumber { get; set; }
        public DateTime? GebCreationDate { get; set; }
        public DateTime? PmtCreationDate { get; set; }
        public DateTime? GebValueDate { get; set; }
        public DateTime? PmtValueDate { get; set; }
        public decimal? GebAmount { get; set; }
        public decimal? PmtAmount { get; set; }
        public int? GebNumberOfTrans { get; set; }
        public int? PmtNumberOfTrans { get; set; }
        public int? GebPaymentMethodId { get; set; }
        public int? PmtPaymentMethodId { get; set; }
        public string GebCurrency { get; set; }
        public string PmtCurrency { get; set; }
        public string GebCustomerCurrentAccount { get; set; }
        public string PmtCustomerCurrentAccount { get; set; }
        public string GebCustomerAbbreviation { get; set; }
        public string PmtCustomerAbbreviation { get; set; }
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
