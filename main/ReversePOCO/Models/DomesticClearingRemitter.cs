using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRemitter
    {
        public DomesticClearingRemitter()
        {
            DomesticClearingRemitterLogs = new HashSet<DomesticClearingRemitterLog>();
        }

        public int RemitterId { get; set; }
        public string CustomerAbbreviation { get; set; }
        public string RemitterName { get; set; }
        public int? StatusId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public int? PreviousStatusId { get; set; }

        public virtual DomesticClearingStatu Status { get; set; }
        public virtual ICollection<DomesticClearingRemitterLog> DomesticClearingRemitterLogs { get; set; }
    }
}
