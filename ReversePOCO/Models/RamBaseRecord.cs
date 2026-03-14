using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class RamBaseRecord
    {
        public DateTime ProcessDate { get; set; }
        public string RamTypeCode { get; set; }
        public string Kind { get; set; }
        public string Ccy { get; set; }
        public int RecTotal { get; set; }
        public string Department { get; set; }
        public string Branch { get; set; }
        public decimal ApprovedAmt { get; set; }
        public int RecDeleted { get; set; }
        public decimal? DeletedAmt { get; set; }
    }
}
