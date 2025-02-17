using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectPaymentPayment
    {
        public int RecCollectPaymentPaymentId { get; set; }
        public int RecCollectionId { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Fees { get; set; }
        public string CurrencyCode { get; set; }
        public string CustomerCurrentAccount { get; set; }
        public int? StatusId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public string GcmsreferenceNumber { get; set; }
        public int? DirectionId { get; set; }
        public int? MainPostId { get; set; }
        public int? FeePostId { get; set; }
        public string CustomerAbbreviation { get; set; }
        public int? PaymentMethodId { get; set; }
        public string BranchNo { get; set; }
        public bool? SentClearer { get; set; }
        public int? NumberOfTrans { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
