using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class FxTransactionExt
    {
        public string RefNo { get; set; }
        public long? PackageId { get; set; }
        public long RootContractId { get; set; }
        public long BaseContractId { get; set; }
        public long ContractId { get; set; }
        public long TradeId { get; set; }
        public string Event { get; set; }
        public string PortfolioGroup { get; set; }
        public string PortfolioDesk { get; set; }
        public string PortfolioBook { get; set; }
        public decimal? BrokerFeeAmount { get; set; }
        public string SourceSystem { get; set; }
        public string SourceId { get; set; }
        public string SourceCtpy { get; set; }
        public string DealingMethod { get; set; }
        public string AuthorisedDealer { get; set; }
        public string ContractCcyAbbrOrig { get; set; }
        public string EquivCcyAbbrOrig { get; set; }
        public bool? Printed { get; set; }
        public DateTime? PrintDateTime { get; set; }
        public bool Gidupload { get; set; }
    }
}
