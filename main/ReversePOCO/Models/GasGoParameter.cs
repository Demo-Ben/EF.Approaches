using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GasGoParameter
    {
        public string TypeTx { get; set; }
        public string AcubuTx { get; set; }
        public string BackvalueInd { get; set; }
        public string DrAccCodeTx { get; set; }
        public string DrEntityTx { get; set; }
        public string DrDivisionTx { get; set; }
        public string CrAccCodeTx { get; set; }
        public string CrEntityTx { get; set; }
        public string CrDivisionTx { get; set; }
        public string ExchrateInd { get; set; }
        public string RemarksTx { get; set; }
        public string DrChecknoTx { get; set; }
        public string CrChecknoTx { get; set; }
    }
}
