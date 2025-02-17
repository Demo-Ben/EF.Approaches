using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingUnitCodeAccountLog
    {
        public int UnitCodeAccountLogId { get; set; }
        public int UnitCodeAccountId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }

        public virtual DomesticClearingUnitCodeAccount UnitCodeAccount { get; set; }
    }
}
