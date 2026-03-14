using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class FxTransaction
    {
        public string RefNo { get; set; }
        public string DealNo { get; set; }
        public short TransCode { get; set; }
        public string Dealtype { get; set; }
        public string Subtype { get; set; }
        public string ActCd { get; set; }
        public string ActAbbr { get; set; }
        public string CustCode { get; set; }
        public string CustAbbr { get; set; }
        public string BranchNo { get; set; }
        public string DivisionCd { get; set; }
        public string IbfId { get; set; }
        public string SchemeNo { get; set; }
        public string Authorized { get; set; }
        public string Revise { get; set; }
        public string CoverPoFlg { get; set; }
        public DateTime? ContractDateOpe { get; set; }
        public DateTime? ContractDateValue { get; set; }
        public DateTime? DelivaryDate { get; set; }
        public DateTime? DelivaryThru { get; set; }
        public DateTime? AccrualFrom { get; set; }
        public DateTime? AccrualTo { get; set; }
        public DateTime? SettlementValueDate { get; set; }
        public string CcyCd { get; set; }
        public string ContractCcyCd { get; set; }
        public string ContractCcyAbbr { get; set; }
        public decimal? ContractCcyAmt { get; set; }
        public decimal? ContractCcyBal { get; set; }
        public decimal? ContractCcyTtb { get; set; }
        public string EquivCcyCd { get; set; }
        public string EquivCcyAbbr { get; set; }
        public decimal? EquivCcyAmt { get; set; }
        public decimal? EquivCcyBal { get; set; }
        public decimal? EquivCcyTtb { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? InternalRate { get; set; }
        public decimal? Spread { get; set; }
        public string AccountEntry { get; set; }
        public string Broker { get; set; }
        public string Remarks { get; set; }
        public string RemarksTrd { get; set; }
        public string SwapRefNo { get; set; }
        public string StatusCd { get; set; }
        public string Addressee { get; set; }
        public string Code56 { get; set; }
        public string Code57 { get; set; }
        public string Code57a { get; set; }
        public string Code58 { get; set; }
        public string SetInstruction { get; set; }
        public string Dealer { get; set; }
        public int? OptionsFlag { get; set; }
        public int? ExecutionRefNo { get; set; }
        public string AddBy { get; set; }
        public DateTime AddOn { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime AuthorizeOn { get; set; }
        public string VerifyBy { get; set; }
        public DateTime VerifyOn { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyOn { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteOn { get; set; }
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string GipStatus { get; set; }
        public string GipDescription { get; set; }
        public string TranNo { get; set; }

        public virtual CustomerMaster CustomerMaster { get; set; }
        public virtual FxSettlementInf FxSettlementInf { get; set; }
    }
}
