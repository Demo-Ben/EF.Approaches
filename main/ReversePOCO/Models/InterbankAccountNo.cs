using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class InterbankAccountNo
    {
        public int Id { get; set; }
        public string SwiftId { get; set; }
        public string CustAbbr { get; set; }
        public string Name { get; set; }
        public string CcyCd { get; set; }
        public string CcyAbbr { get; set; }
        public string ActCd { get; set; }
        public string ActNo { get; set; }
        public string SwiftFlg { get; set; }
        public string BranchNo { get; set; }
        public bool? DefaultFlg { get; set; }
    }
}
