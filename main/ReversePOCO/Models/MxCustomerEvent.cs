using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxCustomerEvent
    {
        public MxCustomerEvent()
        {
            MxGuideCustDetails = new HashSet<MxGuideCustDetail>();
        }

        public int Id { get; set; }
        public string Event { get; set; }

        public virtual ICollection<MxGuideCustDetail> MxGuideCustDetails { get; set; }
    }
}
