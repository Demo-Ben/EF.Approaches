using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class SystemMessage
    {
        public decimal MessageId { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAmendedDate { get; set; }
    }
}
