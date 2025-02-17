using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class BankInf
    {
        public BankInf()
        {
            BankInfCorrs = new HashSet<BankInfCorr>();
        }

        public string SwiftId { get; set; }
        public string BranchNo { get; set; }
        public string SettlBranchNo { get; set; }
        public string Acronym { get; set; }
        public string NameAddr1 { get; set; }
        public string NameAddr2 { get; set; }
        public string NameAddr3 { get; set; }
        public string NameAddr4 { get; set; }
        public string LocationCountry { get; set; }
        public string SwiftFlg { get; set; }
        public string ChipsUid { get; set; }
        public string ChipsAba { get; set; }
        public string FedId { get; set; }
        public string ChapsSortCd { get; set; }
        public string CorBankCd { get; set; }
        public string MhcbBrAbbr { get; set; }
        public string CustAbbr { get; set; }
        public string Remarks { get; set; }
        public string AddBy { get; set; }
        public DateTime AddOn { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime AuthorizeOn { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyOn { get; set; }
        public string DeleteBy { get; set; }
        public DateTime DeleteOn { get; set; }
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string GipStatus { get; set; }
        public string GipDescription { get; set; }
        public string TranNo { get; set; }

        public virtual ICollection<BankInfCorr> BankInfCorrs { get; set; }
    }
}
