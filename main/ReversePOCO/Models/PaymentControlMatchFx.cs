using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlMatchFx
    {
        public int MatchFxid { get; set; }
        public string GbaseRefNo { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        public bool IsBank { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual PaymentControlPayment Payment { get; set; }
    }
}
