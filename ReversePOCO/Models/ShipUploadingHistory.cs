using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class ShipUploadingHistory
    {
        public int UploadingId { get; set; }
        public string ShipMinNo { get; set; }
        public string ShipSeqNo { get; set; }
        public string UploadSeq { get; set; }
        public string TranNumber { get; set; }
        public string Status { get; set; }
        public DateTime? InsertDate { get; set; }
        public string Description { get; set; }
        public string Scenario { get; set; }
        public string GbaseRef { get; set; }
        public string Ccy { get; set; }
    }
}
