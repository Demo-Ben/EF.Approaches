using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxEucBalanceEvent
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public DateTime TimeSent { get; set; }
        public string Status { get; set; }
        public DateTime StatusUpdateTime { get; set; }
        public string Category { get; set; }
        public string EventType { get; set; }
        public string GbaseReferenceNo { get; set; }
        public string CustomerAbbreviation { get; set; }
        public string BranchNo { get; set; }
        public int? Account { get; set; }
        public string TradeDate { get; set; }
        public string EffectiveDate { get; set; }
        public decimal? NominalAmount { get; set; }
        public decimal? SettlementAmount { get; set; }
        public string Currency { get; set; }
        public string BorrowOrLend { get; set; }
        public string ClosingDate { get; set; }
        public string MaturityDate { get; set; }
        public string Revolving { get; set; }
        public string FacilityType { get; set; }
        public string TradeExternalId { get; set; }
        public decimal? Rates { get; set; }
        public decimal? InitialRate { get; set; }
        public decimal? SalesMargin { get; set; }
        public int? BatchNo { get; set; }
    }
}
