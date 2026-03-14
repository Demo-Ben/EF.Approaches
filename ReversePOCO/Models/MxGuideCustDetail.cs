using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxGuideCustDetail
    {
        public MxGuideCustDetail()
        {
            Fxfcusts = new HashSet<Fxfcust>();
        }

        public int Id { get; set; }
        public int? MxCustomerEvent { get; set; }
        public int? MxCustomerStatus { get; set; }
        public string EventId { get; set; }
        public DateTime? TimeSent { get; set; }

        public virtual MxCustomerEvent MxCustomerEventNavigation { get; set; }
        public virtual MxCustomerStatu MxCustomerStatusNavigation { get; set; }
        public virtual ICollection<Fxfcust> Fxfcusts { get; set; }
    }
}
