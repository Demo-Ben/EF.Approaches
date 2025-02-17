using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlAccordConfirmation
    {
        public int AccordConfirmationId { get; set; }
        public string Entity { get; set; }
        public string UserStatus { get; set; }
        public string LockedBy { get; set; }
        public string TaggedTo { get; set; }
        public string Direction { get; set; }
        public string A20sendersReference { get; set; }
        public string Counterparty { get; set; }
        public string DealStatus { get; set; }
        public string NumberOfPairs { get; set; }
        public string ErrorWarning { get; set; }
        public DateTime? B30ttradeDate { get; set; }
        public DateTime? B30vvalueDate { get; set; }
        public decimal? B132bboughtAmt { get; set; }
        public string B132bboughtCcy { get; set; }
        public decimal? B233bsoldAmt { get; set; }
        public string B233bsoldCcy { get; set; }
        public string A22aoperationType { get; set; }
        public decimal? B36exchangeRate { get; set; }
        public string A94aoperationScope { get; set; }
        public string A82apartyA { get; set; }
        public string A87apartyB { get; set; }
        public string ThirdParty { get; set; }
        public string ManuallyMatched { get; set; }
        public string Note { get; set; }
        public string ItemStatus { get; set; }
        public DateTime? ArchivalDate { get; set; }
        public DateTime? DealStatusDate { get; set; }
        public string CounterpartyReport { get; set; }
        public string LastInChain { get; set; }
        public string ConfirmationType { get; set; }
        public string NumberOfLinks { get; set; }
        public string ThirdPartyStatus { get; set; }
        public string IsLocked { get; set; }
        public string IsTagged { get; set; }
        public string MatchingComments { get; set; }
        public string CounterpartyTrn { get; set; }
        public string CounterpartyBic { get; set; }
        public string A83funds { get; set; }
        public string B153deliveryAgent { get; set; }
        public string B156intermediary { get; set; }
        public string B157receivingAgent { get; set; }
        public string B253deliveryAgent { get; set; }
        public string B256intermediary { get; set; }
        public string B257receivingAgent { get; set; }
        public string B258beneficiary { get; set; }
        public DateTime? DealChangeDate { get; set; }
        public string NumberOfChasersSent { get; set; }
        public string TypeOfLinks { get; set; }
        public string FirstUtinamespace { get; set; }
        public string FirstTransactionId { get; set; }
        public string CounterpartyFirstUtinamespace { get; set; }
        public string CounterpartyFirstTransactionId { get; set; }
        public bool Processed { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public int? PaymentId { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime? B30pmaturityDate { get; set; }
        public string B32bprincipalCcy { get; set; }
        public decimal? B32bprincipalAmount { get; set; }
        public decimal? B34einterestAmount { get; set; }
        public DateTime CreatedWhen { get; set; }
        public string B17rpartyAsRole { get; set; }
        public string A22btypeOfEvent { get; set; }
        public decimal? B37ginterestRate { get; set; }
        public string A21ncontractNumber { get; set; }
        public string B32hsettlementAmount { get; set; }
        public string C56intermediaryPartyA { get; set; }
        public string C57receivingAgentPartyA { get; set; }
        public string D56intermediaryPartyB { get; set; }
        public string D57receivingAgentPartyB { get; set; }
        public string E56intermediaryInterestPartyA { get; set; }
        public string E57receivingAgentInterestPartyA { get; set; }
        public string F56intermediaryInterestPartyB { get; set; }
        public string F57receivingAgentInterestPartyB { get; set; }
        public DateTime? B30xnextInterestDate { get; set; }

        public virtual PaymentControlPayment Payment { get; set; }
    }
}
