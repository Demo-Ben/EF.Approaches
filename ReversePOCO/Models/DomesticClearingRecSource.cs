using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecSource
    {
        public DomesticClearingRecSource()
        {
            DomesticClearingRecCollections = new HashSet<DomesticClearingRecCollection>();
        }

        public int RecSourceId { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual ICollection<DomesticClearingRecCollection> DomesticClearingRecCollections { get; set; }
    }
}
