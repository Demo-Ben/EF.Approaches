using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class TransactionKindAdvancedNotice
    {
        public string TransactionKind { get; set; }
        public string Typology { get; set; }
        public string Days { get; set; }
        public string Instrument { get; set; }
        public string Actabbr { get; set; }
        public string Actname { get; set; }
        public string Rate { get; set; }
        public string BranchNo { get; set; }
        public string LegalEntity { get; set; }
        public string TicketProductName { get; set; }
        public string ComfirmationType { get; set; }
    }
}
