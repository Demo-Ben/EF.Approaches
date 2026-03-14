using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class SettlementInf
    {
        public int SifId { get; set; }
        public string BranchNo { get; set; }
        public string RecordKind { get; set; }
        public string CustAbbr { get; set; }
        public string CcyCd { get; set; }
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
        public string PriortyFlg { get; set; }
        public string BankFlg { get; set; }
        public string CoverPoFlg { get; set; }
        public string AdviceRecFlg { get; set; }
        public decimal? AdviceRecLimit { get; set; }
        public string RecBankId { get; set; }
        public string RecCustAbbr { get; set; }
        public string IntermediaryBankId { get; set; }
        public string AccBankId { get; set; }
        public string AccBankActno { get; set; }
        public string BeneBankId { get; set; }
        public string BeneBankActno { get; set; }
        public string ConfirmationSwiftId { get; set; }
        public string ConfirmationFlg { get; set; }
        public string RecBankBrActno { get; set; }
        public string RecBankHoActno { get; set; }
        public string BankInfFlg { get; set; }
        public string BankInf { get; set; }
        public string OcnnectFlg { get; set; }
        public DateTime? OpeDate { get; set; }
        public string Remarks { get; set; }
        public string StatusCd { get; set; }
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
    }
}
