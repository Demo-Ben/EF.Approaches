using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingProduct
    {
        public DomesticClearingProduct()
        {
            DomesticClearingPayments = new HashSet<DomesticClearingPayment>();
            DomesticClearingProductLogs = new HashSet<DomesticClearingProductLog>();
        }

        public int ProductId { get; set; }
        public string Type { get; set; }
        public int? StatusId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public int? PreviousStatusId { get; set; }

        public virtual DomesticClearingStatu Status { get; set; }
        public virtual ICollection<DomesticClearingPayment> DomesticClearingPayments { get; set; }
        public virtual ICollection<DomesticClearingProductLog> DomesticClearingProductLogs { get; set; }
    }
}
