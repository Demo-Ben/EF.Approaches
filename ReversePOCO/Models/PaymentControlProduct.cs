using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlProduct
    {
        public PaymentControlProduct()
        {
            PaymentControlProductReferences = new HashSet<PaymentControlProductReference>();
        }

        public int ProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual ICollection<PaymentControlProductReference> PaymentControlProductReferences { get; set; }
    }
}
