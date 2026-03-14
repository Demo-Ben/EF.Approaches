using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingSource
    {
        public DomesticClearingSource()
        {
            DomesticClearingPaymentMethods = new HashSet<DomesticClearingPaymentMethod>();
        }

        public int SourceId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual ICollection<DomesticClearingPaymentMethod> DomesticClearingPaymentMethods { get; set; }
    }
}
