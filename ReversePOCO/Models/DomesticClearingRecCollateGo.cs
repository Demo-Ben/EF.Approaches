using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollateGo
    {
        public int RecCollateGoid { get; set; }
        public int RecCollectionId { get; set; }
        public int RecBatchId { get; set; }
        public string TransNo { get; set; }
        public DateTime? OperationDate { get; set; }
        public string Remark { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public string DebitCurrency { get; set; }
        public string CreditCurrency { get; set; }
        public string DebitAccountCode { get; set; }
        public string DebitAccountNumber { get; set; }
        public string CreditAccountCode { get; set; }
        public string CreditAccountNumber { get; set; }
        public string DebitCustomerAbbreviation { get; set; }
        public string CreditCustomerAbbreviation { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
