using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MxGuideCustDetailBakMurexRelease
    {
        public int Id { get; set; }
        public int? MxCustomerEvent { get; set; }
        public int? MxCustomerStatus { get; set; }
        public string EventId { get; set; }
        public DateTime? TimeSent { get; set; }
    }
}
