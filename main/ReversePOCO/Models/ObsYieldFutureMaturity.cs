using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class ObsYieldFutureMaturity
    {
        public string ContractName { get; set; }
        public string Ccy { get; set; }
        public string MurexMaturityLable { get; set; }
        public DateTime? Maturity { get; set; }
    }
}
