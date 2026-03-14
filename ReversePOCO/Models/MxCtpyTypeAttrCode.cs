using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxCtpyTypeAttrCode
    {
        public int Id { get; set; }
        public int CounterpartyType { get; set; }
        public string AttributeCode { get; set; }
        public string Branch { get; set; }

        public virtual MxCounterpartyType CounterpartyTypeNavigation { get; set; }
        public virtual EucCustAttributeCode EucCustAttributeCode { get; set; }
    }
}
