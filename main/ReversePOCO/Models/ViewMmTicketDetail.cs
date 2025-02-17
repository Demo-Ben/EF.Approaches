using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class ViewMmTicketDetail
    {
        public string MmticketId { get; set; }
        public string TicketTemplate { get; set; }
        public string LegalEntity { get; set; }
        public string Event { get; set; }
        public string Typology { get; set; }
        public string CounterpartyShortName { get; set; }
        public string CounterpartyDescription { get; set; }
        public string MurexTradeId { get; set; }
        public string PortfolioGroup { get; set; }
        public string PortfolioDesk { get; set; }
        public string PortfolioBook { get; set; }
        public DateTime OperationDate { get; set; }
        public string DealingMethod { get; set; }
        public string DealingContact { get; set; }
        public string GbaseRefNo { get; set; }
        public string Ibf { get; set; }
        public string CounterpartyAbbreviation { get; set; }
        public int DivisionCode { get; set; }
        public int? Discount { get; set; }
        public string SchemeNumber { get; set; }
        public string Authorised { get; set; }
        public string Currency { get; set; }
        public decimal? PrincipalAmount { get; set; }
        public int? RolloverNumber { get; set; }
        public string RateConvention { get; set; }
        public DateTime? ValueDate { get; set; }
        public DateTime? FinalDueDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string Broker { get; set; }
        public int? TermDays { get; set; }
        public int? RateType { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? InterestAmount { get; set; }
        public string FundType { get; set; }
        public decimal? InternalRate { get; set; }
        public string InterestSet { get; set; }
        public string InterestSetLabel { get; set; }
        public string WithholdingTaxBearer { get; set; }
        public string WithholdingTaxBearerLabel { get; set; }
        public string WithholdingTaxCode { get; set; }
        public decimal? WithholdingTaxRate { get; set; }
        public decimal? WithholdingTaxAmount { get; set; }
        public string Remarks { get; set; }
        public string FrontOfficeInputBy { get; set; }
        public string FrontOfficeAuthorisedBy { get; set; }
        public DateTime? ContractDate { get; set; }
        public string SettlementDetails { get; set; }
        public decimal? NetInterest { get; set; }
        public decimal? TotalDue { get; set; }
        public decimal? Brokerage { get; set; }
        public decimal? PrincipalAmountPrevious { get; set; }
        public string RolloverType { get; set; }
        public string RolloverTypeLabel { get; set; }
        public decimal? PrincipalAmountClosing { get; set; }
        public string SettlementDirectionLabel { get; set; }
        public decimal? Denomination { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? FaceAmount { get; set; }
        public decimal? ConsiderationAmount { get; set; }
        public string Issuer { get; set; }
        public string IssuerFullName { get; set; }
        public string IssuerGbaseAbbreviation { get; set; }
        public decimal? Yield { get; set; }
        public decimal? IssuePrice { get; set; }
        public int ContractVersion { get; set; }
        public string CustomerCode { get; set; }
        public bool PrintStatus { get; set; }
        public string PayoutType { get; set; }
        public string BuySell { get; set; }
        public DateTime TicketCreatedTimestamp { get; set; }
        public DateTime? TradeDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Nature { get; set; }
        public string Instrument { get; set; }
        public string TransactionStatus { get; set; }
        public string Addresse { get; set; }
        public string PartyIdentifier56 { get; set; }
        public string Bic561 { get; set; }
        public string PartyIdentifier57 { get; set; }
        public string FxalmPartyIdentifier57 { get; set; }
        public string Bic571 { get; set; }
        public string Bic572 { get; set; }
        public string Bic573 { get; set; }
        public string Bic574 { get; set; }
        public string PartyIdentifier58 { get; set; }
        public string FxalmPartyIdentifier58 { get; set; }
        public string Bic581 { get; set; }
        public string PartyIdentifier59 { get; set; }
        public string Bic591 { get; set; }
        public string Bic592 { get; set; }
        public string Bic593 { get; set; }
        public string Bic594 { get; set; }
        public string SpecialInstruction1 { get; set; }
        public string SpecialInstruction2 { get; set; }
        public string SpecialInstruction3 { get; set; }
        public string SpecialInstruction4 { get; set; }
        public int AdvancedNoticeDepo { get; set; }
        public string MizuhoTicketProduct { get; set; }
        public bool? IsProduction { get; set; }
    }
}
