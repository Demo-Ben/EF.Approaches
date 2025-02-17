using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlProductReference
    {
        public PaymentControlProductReference()
        {
            PaymentControlPayments = new HashSet<PaymentControlPayment>();
            PaymentControlSwiftPayments = new HashSet<PaymentControlSwiftPayment>();
        }

        public int ProductReferenceId { get; set; }
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool HasConfirmations { get; set; }
        public bool HasSwiftPayments { get; set; }
        public bool IsTaking { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual PaymentControlProduct Product { get; set; }
        public virtual ICollection<PaymentControlPayment> PaymentControlPayments { get; set; }
        public virtual ICollection<PaymentControlSwiftPayment> PaymentControlSwiftPayments { get; set; }
    }
}
