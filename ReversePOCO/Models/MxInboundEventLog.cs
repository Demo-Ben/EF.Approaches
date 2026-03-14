using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxInboundEventLog
    {
        public int LogId { get; set; }
        public DateTime Timestamp { get; set; }
        public string LogLevel { get; set; }
        public string Logger { get; set; }
        public string EventId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Exception { get; set; }
    }
}
