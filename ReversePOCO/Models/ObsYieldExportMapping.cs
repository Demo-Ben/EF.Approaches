using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class ObsYieldExportMapping
    {
        public int Id { get; set; }
        public string ObsCcy { get; set; }
        public string ObsYieldCurveType { get; set; }
        public string ObsYieldMaturity { get; set; }
        public string MurexCcy { get; set; }
        public string Type { get; set; }
        public string Generator { get; set; }
        public string Market { get; set; }
        public string Maturity { get; set; }
    }
}
