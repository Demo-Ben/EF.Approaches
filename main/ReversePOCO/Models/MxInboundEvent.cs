using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxInboundEvent
    {
        public int MessageId { get; set; }
        public DateTime Timestamp { get; set; }
        public string MessageXml { get; set; }
        public string SendingSystem { get; set; }
        public string Category { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }
        public int StatusId { get; set; }
        public string Details { get; set; }
    }
}
