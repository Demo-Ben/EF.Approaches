using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingProductLog
    {
        public int ProductLogId { get; set; }
        public int ProductId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }

        public virtual DomesticClearingProduct Product { get; set; }
    }
}
