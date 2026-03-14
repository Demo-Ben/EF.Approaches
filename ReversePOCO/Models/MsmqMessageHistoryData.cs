using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MsmqMessageHistoryData
    {
        public decimal Id { get; set; }
        public string QueuePath { get; set; }
        public string TransactionRefNo { get; set; }
        public string MessageLabel { get; set; }
        public string MessageBody { get; set; }
        public DateTime? ReceivedTime { get; set; }
    }
}
