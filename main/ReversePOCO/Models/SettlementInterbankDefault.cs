using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class SettlementInterbankDefault
    {
        public int InterbankId { get; set; }
        public string RecordKind { get; set; }
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
        public decimal AdviceRecLimit { get; set; }
        public string RecBankId { get; set; }
        public string AccountNo { get; set; }
        public string ObuAccountNo { get; set; }
        public string Status { get; set; }
        public bool? DefaultFlg { get; set; }
    }
}
