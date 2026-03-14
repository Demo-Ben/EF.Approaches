using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class CustomerMasterModCodesMurexRelease
    {
        public string CustAbbr { get; set; }
        public int? ProdCustId { get; set; }
        public int? ParallelCustId { get; set; }
        public string ProdCustCode { get; set; }
        public string ParallelCustCode { get; set; }
        public string ProdBranchNo { get; set; }
    }
}
