using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecType
    {
        public DomesticClearingRecType()
        {
            DomesticClearingRecBatches = new HashSet<DomesticClearingRecBatch>();
        }

        public int RecTypeId { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual ICollection<DomesticClearingRecBatch> DomesticClearingRecBatches { get; set; }
    }
}
