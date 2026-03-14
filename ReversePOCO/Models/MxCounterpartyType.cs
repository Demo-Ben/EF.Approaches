using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxCounterpartyType
    {
        public MxCounterpartyType()
        {
            MxCtpyTypeAttrCodes = new HashSet<MxCtpyTypeAttrCode>();
            MxCustCounterpartyTypes = new HashSet<MxCustCounterpartyType>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MxCtpyTypeAttrCode> MxCtpyTypeAttrCodes { get; set; }
        public virtual ICollection<MxCustCounterpartyType> MxCustCounterpartyTypes { get; set; }
    }
}
