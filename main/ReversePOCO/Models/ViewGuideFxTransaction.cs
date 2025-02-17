using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class ViewGuideFxTransaction
    {
        public string RefNo { get; set; }
        public string RefNum { get; set; }
        public string DealNo { get; set; }
        public string Shortname { get; set; }
        public string CustAbbr { get; set; }
        public string CustCode { get; set; }
        public string BranchNo { get; set; }
        public DateTime? ContractDateOpe { get; set; }
        public DateTime? ContractDateValue { get; set; }
        public DateTime? DelivaryDate { get; set; }
        public DateTime? DelivaryThru { get; set; }
        public string ContractCcyAbbr { get; set; }
        public decimal? ContractCcyAmt { get; set; }
        public decimal? ContractCcyBal { get; set; }
        public decimal? ContractCcyTtb { get; set; }
        public string EquivCcyAbbr { get; set; }
        public decimal? EquivCcyAmt { get; set; }
        public decimal? EquivCcyBal { get; set; }
        public decimal? EquivCcyTtb { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Dealer { get; set; }
        public int? Optionsflag { get; set; }
        public string SchemeNo { get; set; }
        public int? ExecutionRefNo { get; set; }
        public string TransStatus { get; set; }
        public string TransDeletionStatus { get; set; }
        public string TransGipStatus { get; set; }
        public string TransGipDescription { get; set; }
        public string TransTranNo { get; set; }
        public string TransAddBy { get; set; }
        public string TransModifyBy { get; set; }
        public string TransDeleteBy { get; set; }
        public string TransVerifyBy { get; set; }
        public string TransAuthorizeBy { get; set; }
        public DateTime TransAddOn { get; set; }
        public DateTime TransModifyOn { get; set; }
        public DateTime TransDeleteOn { get; set; }
        public DateTime TransVerifyOn { get; set; }
        public DateTime TransAuthorizeOn { get; set; }
        public string Broker { get; set; }
        public string PayActNo { get; set; }
        public string RecActNo { get; set; }
        public string SellCcy { get; set; }
        public decimal? SellAmt { get; set; }
        public string BuyCcy { get; set; }
        public decimal? BuyAmt { get; set; }
        public decimal? DeliveryContractCcyAmt { get; set; }
        public decimal? DeliveryEquivCcyAmt { get; set; }
        public string RecSettlCode { get; set; }
        public string PaySettlCode { get; set; }
        public string DeliveryStatus { get; set; }
        public string DeliveryDeletionStatus { get; set; }
        public string DeliveryGipStatus { get; set; }
        public string DeliveryGipDescription { get; set; }
        public string DeliveryTranNo { get; set; }
        public string DeliveryAddBy { get; set; }
        public string DeliveryModifyBy { get; set; }
        public string DeliveryDeleteBy { get; set; }
        public string DeliveryVerifyBy { get; set; }
        public string DeliveryAuthorizeBy { get; set; }
        public DateTime DeliveryAddOn { get; set; }
        public DateTime DeliveryModifyOn { get; set; }
        public DateTime DeliveryDeleteOn { get; set; }
        public DateTime DeliveryVerifyOn { get; set; }
        public DateTime DeliveryAuthorizeOn { get; set; }
        public string Bank { get; set; }
    }
}
