using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingFee
    {
        public DomesticClearingFee()
        {
            DomesticClearingFeeLogs = new HashSet<DomesticClearingFeeLog>();
        }

        public int FeeId { get; set; }
        public string CustomerAbbreviation { get; set; }
        public string Account { get; set; }
        public decimal Amount { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int? StatusId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public int PaymentMethodId { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public bool Closed { get; set; }
        public decimal? ReturnAmount { get; set; }
        public int? PreviousStatusId { get; set; }
        public decimal? DishonourAmount { get; set; }

        public virtual DomesticClearingPaymentMethod PaymentMethod { get; set; }
        public virtual DomesticClearingStatu Status { get; set; }
        public virtual ICollection<DomesticClearingFeeLog> DomesticClearingFeeLogs { get; set; }
    }
}
