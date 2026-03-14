using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class CurrExchangeRate
    {
        public DateTime EffectiveDate { get; set; }
        public string ToCcyCode { get; set; }
        public string FromCcyCode { get; set; }
        public decimal OdbRate { get; set; }
        public decimal TtbRate { get; set; }
        public decimal MeanRate { get; set; }
        public decimal OdsRate { get; set; }
        public decimal TtsRate { get; set; }
    }
}
