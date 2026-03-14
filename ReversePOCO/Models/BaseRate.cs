using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class BaseRate
    {
        public DateTime OperationDate { get; set; }
        public DateTime StartDate { get; set; }
        public string Ccy { get; set; }
        public string Source { get; set; }
        public decimal Duration { get; set; }
        public decimal Rate { get; set; }
        public string ImportedBy { get; set; }
        public string RecStatus { get; set; }
    }
}
