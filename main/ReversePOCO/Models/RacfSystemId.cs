using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class RacfSystemId
    {
        public string IdType { get; set; }
        public string SystemId { get; set; }
        public string Password { get; set; }
        public DateTime PwdCreateDate { get; set; }
        public string RacfStatusCode { get; set; }
        public string RacfPreviousPwd { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }
        public string Description { get; set; }
    }
}
