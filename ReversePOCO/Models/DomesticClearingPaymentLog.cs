using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingPaymentLog
    {
        public int PaymentLogId { get; set; }
        public int PaymentId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }

        public virtual DomesticClearingPayment Payment { get; set; }
    }
}
