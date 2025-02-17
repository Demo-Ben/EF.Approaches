using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxCustomerStatu
    {
        public MxCustomerStatu()
        {
            MxGuideCustDetails = new HashSet<MxGuideCustDetail>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<MxGuideCustDetail> MxGuideCustDetails { get; set; }
    }
}
