using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class CorpSettlementAccount
    {
        public int FxId { get; set; }
        public string CustAbbr { get; set; }
        public string CcyCd { get; set; }
        public string RecSettlCode { get; set; }
        public string RecActCd { get; set; }
        public string RecRmtFlg { get; set; }
        public string RecMethod { get; set; }
        public string RecMessageType { get; set; }
        public string PaySettlCode { get; set; }
        public string PayActCd { get; set; }
        public string PayRmtFlg { get; set; }
        public string PayMethod { get; set; }
        public string PayMessageType { get; set; }
        public string PriortyFlg { get; set; }
        public string BankFlg { get; set; }
        public string CoverPoFlg { get; set; }
        public string AdviceRecFlg { get; set; }
        public decimal? AdviceRecLimit { get; set; }
        public string RecBankId { get; set; }
        public string Status { get; set; }
        public string AddBy { get; set; }
        public DateTime? AddOn { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime? AuthorizeOn { get; set; }
    }
}
