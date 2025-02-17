using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GlinkQueueManagerAction
    {
        public decimal Id { get; set; }
        public DateTime ActionDate { get; set; }
        public string ActionType { get; set; }
        public string ActionObject { get; set; }
        public string ActionDescription { get; set; }
    }
}
