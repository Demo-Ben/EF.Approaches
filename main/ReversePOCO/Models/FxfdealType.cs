using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class FxfdealType
    {
        public int DealtypeId { get; set; }
        public string Tranname { get; set; }
        public string Dealtype { get; set; }
        public string Subtype { get; set; }
        public short? ProdId { get; set; }
        public int? UseInCredit { get; set; }
        public string ShortName { get; set; }
        public short? FilimitTypeId { get; set; }
        public short? CorpLimitTypeId { get; set; }
        public short? CalcTypeId { get; set; }
        public short? ProductcodeId { get; set; }
        public short? FactorTypeId { get; set; }
        public bool? Active { get; set; }
        public string Typology { get; set; }
        public string RefType { get; set; }
    }
}
