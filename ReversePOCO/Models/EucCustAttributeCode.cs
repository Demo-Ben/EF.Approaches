using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class EucCustAttributeCode
    {
        public EucCustAttributeCode()
        {
            MxCtpyTypeAttrCodes = new HashSet<MxCtpyTypeAttrCode>();
        }

        public string AttributeCd { get; set; }
        public string AttributeName { get; set; }
        public string BranchNo { get; set; }

        public virtual ICollection<MxCtpyTypeAttrCode> MxCtpyTypeAttrCodes { get; set; }
    }
}
