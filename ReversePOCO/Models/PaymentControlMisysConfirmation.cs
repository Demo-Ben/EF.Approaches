using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlMisysConfirmation
    {
        public int MisysConfirmationId { get; set; }
        public bool Processed { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public int? PaymentId { get; set; }
        public string Counterparty { get; set; }
        public string FinStatus { get; set; }
        public string InstStatus { get; set; }
        public string DmStatus { get; set; }
        public string ReferenceNum { get; set; }
        public string Fund { get; set; }
        public DateTime? TradeDate { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? Rate { get; set; }
        public string BuyCcy { get; set; }
        public decimal? BuyAmount { get; set; }
        public string BuyReceivingAgent { get; set; }
        public string SellCcy { get; set; }
        public decimal? SellAmount { get; set; }
        public string SellReceivingAgent { get; set; }
        public string DealType { get; set; }
        public string RelatedRefNo { get; set; }
        public string TypeOfOprn { get; set; }
        public string PartyAsRole { get; set; }
        public DateTime? MaturityDate { get; set; }
        public string PrincipleCurr { get; set; }
        public decimal? PrincipleAmt { get; set; }
        public string IntCurr { get; set; }
        public decimal? IntAmt { get; set; }
        public string InterestRate { get; set; }

        public virtual PaymentControlPayment Payment { get; set; }
    }
}
