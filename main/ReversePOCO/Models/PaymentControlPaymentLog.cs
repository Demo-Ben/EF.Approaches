using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlPaymentLog
    {
        public int PaymentLogId { get; set; }
        public int PaymentId { get; set; }
        public DateTime When { get; set; }
        public string Who { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }

        public virtual PaymentControlPayment Payment { get; set; }
    }
}
