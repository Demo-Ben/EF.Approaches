using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class CustAccountNo
    {
        public int ActId { get; set; }
        public string ActCd { get; set; }
        public string CcyCd { get; set; }
        public string ActNo { get; set; }
        public string ActDescription { get; set; }
        public string Ubo { get; set; }
        public string BranchNo { get; set; }
        public string AddBy { get; set; }
        public DateTime? AddOn { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime? AuthorizeOn { get; set; }
        public string Status { get; set; }
    }
}
