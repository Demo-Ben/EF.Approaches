using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingFeeLog
    {
        public int FeeLogId { get; set; }
        public int FeeId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }

        public virtual DomesticClearingFee Fee { get; set; }
    }
}
