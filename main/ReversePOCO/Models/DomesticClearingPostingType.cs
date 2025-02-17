using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingPostingType
    {
        public DomesticClearingPostingType()
        {
            DomesticClearingGopostings = new HashSet<DomesticClearingGoposting>();
        }

        public int PostingTypeId { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime? CreatedWhen { get; set; }

        public virtual ICollection<DomesticClearingGoposting> DomesticClearingGopostings { get; set; }
    }
}
