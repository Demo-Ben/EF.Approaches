using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MsmqMessageData
    {
        public decimal Id { get; set; }
        public DateTime ReceivedTime { get; set; }
        public string QueueName { get; set; }
        public string MessageLabel { get; set; }
        public string MessageBody { get; set; }
    }
}
