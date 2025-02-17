using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecRecGo
    {
        public int RecRecGoid { get; set; }
        public int RecBatchId { get; set; }
        public int? GoRecCollateGoid { get; set; }
        public int? GasRecCollateGoid { get; set; }
        public int? EucRecCollateGoid { get; set; }
        public string TransNo { get; set; }
        public DateTime? OperationDate { get; set; }
        public string GoRemark { get; set; }
        public string GasRemark { get; set; }
        public string EucRemark { get; set; }
        public DateTime? GoValueDate { get; set; }
        public DateTime? GasValueDate { get; set; }
        public DateTime? EucValueDate { get; set; }
        public decimal? GoDebitAmount { get; set; }
        public decimal? GasDebitAmount { get; set; }
        public decimal? EucDebitAmount { get; set; }
        public decimal? GoCreditAmount { get; set; }
        public decimal? GasCreditAmount { get; set; }
        public decimal? EucCreditAmount { get; set; }
        public string GoDebitCurrency { get; set; }
        public string GasDebitCurrency { get; set; }
        public string EucDebitCurrency { get; set; }
        public string GoCreditCurrency { get; set; }
        public string GasCreditCurrency { get; set; }
        public string EucCreditCurrency { get; set; }
        public string GoDebitAccountCode { get; set; }
        public string GasDebitAccountCode { get; set; }
        public string EucDebitAccountCode { get; set; }
        public string GoDebitAccountNumber { get; set; }
        public string GasDebitAccountNumber { get; set; }
        public string EucDebitAccountNumber { get; set; }
        public string GoCreditAccountCode { get; set; }
        public string GasCreditAccountCode { get; set; }
        public string EucCreditAccountCode { get; set; }
        public string GoCreditAccountNumber { get; set; }
        public string GasCreditAccountNumber { get; set; }
        public string EucCreditAccountNumber { get; set; }
        public string GoDebitCustomerAbbreviation { get; set; }
        public string GasDebitCustomerAbbreviation { get; set; }
        public string EucDebitCustomerAbbreviation { get; set; }
        public string GoCreditCustomerAbbreviation { get; set; }
        public string GasCreditCustomerAbbreviation { get; set; }
        public string EucCreditCustomerAbbreviation { get; set; }
        public int? RecKeyStatusId { get; set; }
        public int? RecValueStatusId { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        public virtual DomesticClearingRecKeyStatu RecKeyStatus { get; set; }
        public virtual DomesticClearingRecValueStatu RecValueStatus { get; set; }
    }
}
