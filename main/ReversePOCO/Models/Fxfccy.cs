using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class Fxfccy
    {
        public int CcyId { get; set; }
        public string Ccy { get; set; }
        public string Ccydesc { get; set; }
        public short? Days { get; set; }
        public bool Direct { get; set; }
        public string DreamsDesc { get; set; }
        public int Spreadvalue { get; set; }
        public int? Fxblotterorder { get; set; }
        public string CcyCd { get; set; }
        public string AudcrossCcyname { get; set; }
        public bool? Active { get; set; }
        public string ReutersRateType { get; set; }
        public string MurexRateQuotation { get; set; }
    }
}
