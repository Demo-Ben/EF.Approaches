using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class AuditEvent
    {
        public decimal Identifier { get; set; }
        public string Description { get; set; }
        public string ExceptionFlag { get; set; }
    }
}
