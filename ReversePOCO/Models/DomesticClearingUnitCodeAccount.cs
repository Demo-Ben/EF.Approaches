using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingUnitCodeAccount
    {
        public DomesticClearingUnitCodeAccount()
        {
            DomesticClearingUnitCodeAccountLogs = new HashSet<DomesticClearingUnitCodeAccountLog>();
        }

        public int UnitCodeAccountId { get; set; }
        public string UnitCode { get; set; }
        public string CustomerCurrentAccount { get; set; }
        public int? StatusId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public int? PreviousStatusId { get; set; }

        public virtual DomesticClearingStatu Status { get; set; }
        public virtual ICollection<DomesticClearingUnitCodeAccountLog> DomesticClearingUnitCodeAccountLogs { get; set; }
    }
}
