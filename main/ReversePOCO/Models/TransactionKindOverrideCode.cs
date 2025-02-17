using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class TransactionKindOverrideCode
    {
        public string CounterpartyLabel { get; set; }
        public string GbaseCustomerAbbrev { get; set; }
        public string MxTypology { get; set; }
        public string MxPayout { get; set; }
        public string TransactionKind { get; set; }
    }
}
