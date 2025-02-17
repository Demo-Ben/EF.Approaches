using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectGoGasGoCredit
    {
        public int RecCollectGogasGoCreditId { get; set; }
        public int RecCollectionId { get; set; }
        public string MinNo { get; set; }
        public string GroupnoTx { get; set; }
        public string CcyTx { get; set; }
        public decimal? AmountAmt { get; set; }
        public string CustidTx { get; set; }
        public string AccCdTx { get; set; }
        public string AccnumTx { get; set; }
        public string DetailsTx { get; set; }
        public string AdviseprintTx { get; set; }
        public string FxccyTx { get; set; }
        public decimal? InterrateInt { get; set; }
        public decimal? ExchrateInt { get; set; }
        public string EntityTx { get; set; }
        public string DivisionTx { get; set; }
        public string TypeTx { get; set; }
        public string ChecknoTx { get; set; }
        public string FundTx { get; set; }
        public DateTime? AvailableDate { get; set; }
        public string IbfTx { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
