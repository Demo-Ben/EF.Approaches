using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class BankInfCorr
    {
        public int BankInfId { get; set; }
        public string SwiftId { get; set; }
        public string CcyCd { get; set; }
        public string MmSettlBankId { get; set; }
        public string MmSettlBankActno { get; set; }
        public string BranchNo { get; set; }
        public string SettlBranchNo { get; set; }
        public string AddBy { get; set; }
        public DateTime AddOn { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime AuthorizeOn { get; set; }
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string GipStatus { get; set; }
        public string TranNo { get; set; }

        public virtual BankInf S { get; set; }
    }
}
