using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class AuditTrail
    {
        public decimal Identifier { get; set; }
        public string UserId { get; set; }
        public DateTime EventDate { get; set; }
        public decimal EventIdentifier { get; set; }
        public string Details { get; set; }
        public decimal? SmIdentifier { get; set; }
        public string DeptCode { get; set; }
    }
}
