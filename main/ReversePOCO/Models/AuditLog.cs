using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class AuditLog
    {
        public int AuditId { get; set; }
        public string UserId { get; set; }
        public DateTime? AuditDate { get; set; }
        public string RefNo { get; set; }
        public string TransNo { get; set; }
        public string AuditDesc { get; set; }
        public string AppName { get; set; }
        public string TableName { get; set; }
        public string OriginalValue { get; set; }
        public string NewValue { get; set; }
    }
}
