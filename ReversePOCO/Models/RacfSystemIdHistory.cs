using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class RacfSystemIdHistory
    {
        public string IdType { get; set; }
        public string SystemId { get; set; }
        public string Password { get; set; }
        public DateTime PwdCreateDate { get; set; }
    }
}
