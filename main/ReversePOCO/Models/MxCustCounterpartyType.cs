using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxCustCounterpartyType
    {
        public int Id { get; set; }
        public int CustId { get; set; }
        public int CounterpartyTypeId { get; set; }

        public virtual MxCounterpartyType CounterpartyType { get; set; }
        public virtual Fxfcust Cust { get; set; }
    }
}
