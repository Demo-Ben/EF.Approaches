using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class FxSettlementInf
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public string BranchNo { get; set; }
        public string CustAbbr { get; set; }
        public string RecSettlCode { get; set; }
        public string RecCcyCd { get; set; }
        public string RecActCd { get; set; }
        public string RecActNo { get; set; }
        public string RecCustAbbr { get; set; }
        public string RecMethod { get; set; }
        public string RecMessageType { get; set; }
        public string RecRmtFlg { get; set; }
        public string RecAdviceRecFlg { get; set; }
        public string RecPriortyFlg { get; set; }
        public string PriortyFlg { get; set; }
        public string PaySettlCode { get; set; }
        public string PayCcyCd { get; set; }
        public string PayActCd { get; set; }
        public string PayActNo { get; set; }
        public string PayCustAbbr { get; set; }
        public string PayMethod { get; set; }
        public string PayMessageType { get; set; }
        public string PayRmtFlg { get; set; }
        public string PayAdviceRecFlg { get; set; }
        public string PayPriortyFlg { get; set; }
        public string BankFlg { get; set; }
        public string CoverPoFlg { get; set; }
        public decimal? AdviceRecLimit { get; set; }
        public string RecOrderingCustomer { get; set; }
        public string RecRecBank { get; set; }
        public string RecOrderingBank { get; set; }
        public string RecIntermediaryBank { get; set; }
        public string RecKihyoIrai { get; set; }
        public string RecHoFavorMt202 { get; set; }
        public string RecOtherMethod { get; set; }
        public string RecOtherRmtFlg { get; set; }
        public string RecOtherDr { get; set; }
        public string RecOtherCr { get; set; }
        public string PayRecBank { get; set; }
        public string PaySenderCorres { get; set; }
        public string PayIntermediaryBank { get; set; }
        public string PayReceiverCorres { get; set; }
        public string PayAccBank { get; set; }
        public string PayBeneficiary { get; set; }
        public string PayOrderingCustomer { get; set; }
        public string PayPaymentDetails1 { get; set; }
        public string PayPaymentDetails2 { get; set; }
        public string PayPaymentDetails3 { get; set; }
        public string PayPaymentDetails4 { get; set; }
        public string BankToBankInf { get; set; }
        public string PayKihyoIrai { get; set; }
        public string PayHoFavorMt202 { get; set; }
        public string PayOtherMethod { get; set; }
        public string PayOtherRmtFlg { get; set; }
        public string PayOtherDr { get; set; }
        public string PayOtherCr { get; set; }
        public decimal ContractCcyAmt { get; set; }
        public decimal EquivCcyAmt { get; set; }
        public int? OperationId { get; set; }
        public string StatusCd { get; set; }
        public string AddBy { get; set; }
        public DateTime AddOn { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime AuthorizeOn { get; set; }
        public string VerifyBy { get; set; }
        public DateTime? VerifyOn { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyOn { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteOn { get; set; }
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string GipStatus { get; set; }
        public string GipDescription { get; set; }
        public string TranNo { get; set; }

        public virtual FxTransaction RefNoNavigation { get; set; }
    }
}
