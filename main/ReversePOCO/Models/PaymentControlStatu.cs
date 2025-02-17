using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlStatu
    {
        public PaymentControlStatu()
        {
            PaymentControlPayments = new HashSet<PaymentControlPayment>();
            PaymentControlSwiftPayments = new HashSet<PaymentControlSwiftPayment>();
        }

        public int StatusId { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual ICollection<PaymentControlPayment> PaymentControlPayments { get; set; }
        public virtual ICollection<PaymentControlSwiftPayment> PaymentControlSwiftPayments { get; set; }
    }
}
