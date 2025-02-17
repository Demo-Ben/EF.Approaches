using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingStatu
    {
        public DomesticClearingStatu()
        {
            DomesticClearingFees = new HashSet<DomesticClearingFee>();
            DomesticClearingPaymentLines = new HashSet<DomesticClearingPaymentLine>();
            DomesticClearingPayments = new HashSet<DomesticClearingPayment>();
            DomesticClearingProducts = new HashSet<DomesticClearingProduct>();
            DomesticClearingRemitters = new HashSet<DomesticClearingRemitter>();
            DomesticClearingUnitCodeAccounts = new HashSet<DomesticClearingUnitCodeAccount>();
        }

        public int StatusId { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual ICollection<DomesticClearingFee> DomesticClearingFees { get; set; }
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLines { get; set; }
        public virtual ICollection<DomesticClearingPayment> DomesticClearingPayments { get; set; }
        public virtual ICollection<DomesticClearingProduct> DomesticClearingProducts { get; set; }
        public virtual ICollection<DomesticClearingRemitter> DomesticClearingRemitters { get; set; }
        public virtual ICollection<DomesticClearingUnitCodeAccount> DomesticClearingUnitCodeAccounts { get; set; }
    }
}
