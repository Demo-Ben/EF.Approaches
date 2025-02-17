using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class Fxfswift
    {
        public int Id { get; set; }
        public int SifId { get; set; }
        public string RecordKind { get; set; }
        public string CustCode { get; set; }
        public string CcyCd { get; set; }
        public int? CcyId { get; set; }
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
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string AddBy { get; set; }
        public DateTime? AddOn { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime? AuthorizeOn { get; set; }
    }
}
