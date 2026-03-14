using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class SettlementCorpCustDefault
    {
        public int CorpCustId { get; set; }
        public string BranchNo { get; set; }
        public string RecordKind { get; set; }
        public string CcyAbbr { get; set; }
        public string RecSettlCode { get; set; }
        public string RecActCd { get; set; }
        public string RecActNo { get; set; }
        public string RecRmtFlg { get; set; }
        public string RecMethod { get; set; }
        public string RecMessageType { get; set; }
        public string PaySettlCode { get; set; }
        public string PayActCd { get; set; }
        public string PayActNo { get; set; }
        public string PayRmtFlg { get; set; }
        public string PayMethod { get; set; }
        public string PayMessageType { get; set; }
        public string AdviceRecFlg { get; set; }
        public decimal AdviceRecLimit { get; set; }
        public string PriortyFlg { get; set; }
        public string RecBankId { get; set; }
        public string IntermediaryBankId { get; set; }
        public string OrderingCustomer { get; set; }
        public string OrderingBank { get; set; }
        public string BeneBankId { get; set; }
        public string AccBankId { get; set; }
        public string SenderCorres { get; set; }
        public string RecCorres { get; set; }
        public string Status { get; set; }
        public bool? DefaultFlg { get; set; }
    }
}
