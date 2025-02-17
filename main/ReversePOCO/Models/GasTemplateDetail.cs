using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GasTemplateDetail
    {
        public string TemplateName { get; set; }
        public string ItemNumber { get; set; }
        public string Debit { get; set; }
        public string CustAbbr { get; set; }
        public string CustName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountCode { get; set; }
        public string Advice { get; set; }
        public string Entity { get; set; }
        public string Division { get; set; }
        public string AmountCcy { get; set; }
        public string ExchRateCcy { get; set; }
        public string Details { get; set; }
        public string Fund { get; set; }
        public decimal? AmountAmount { get; set; }
        public decimal? ExchRateAmount { get; set; }
        public decimal? Interrate { get; set; }
        public string IbfTx { get; set; }
    }
}
