using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingDirection
    {
        public DomesticClearingDirection()
        {
            DomesticClearingGopostings = new HashSet<DomesticClearingGoposting>();
            DomesticClearingPaymentMethods = new HashSet<DomesticClearingPaymentMethod>();
            DomesticClearingPayments = new HashSet<DomesticClearingPayment>();
        }

        public int DirectionId { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual ICollection<DomesticClearingGoposting> DomesticClearingGopostings { get; set; }
        public virtual ICollection<DomesticClearingPaymentMethod> DomesticClearingPaymentMethods { get; set; }
        public virtual ICollection<DomesticClearingPayment> DomesticClearingPayments { get; set; }
    }
}
