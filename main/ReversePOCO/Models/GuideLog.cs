using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GuideLog
    {
        public int AuditId { get; set; }
        public DateTime AuditDate { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
}
