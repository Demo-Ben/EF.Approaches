using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class TransactionKindMoneyMarket
    {
        public string BranchCode { get; set; }
        public int BranchNo { get; set; }
        public string TransactionType { get; set; }
        public string AccountCategory { get; set; }
        public string Description { get; set; }
        public string MxLegalEntity { get; set; }
        public string MxTypology { get; set; }
        public string Payout { get; set; }
        public string CounterpartyTypeRule { get; set; }
        public string TermRule { get; set; }
        public string TransactionKind { get; set; }
        public string BuySell { get; set; }
    }
}
