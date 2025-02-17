using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DistributionPassword
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string Password { get; set; }
        public string CustomerBranch { get; set; }
        public string CustomerAbbr { get; set; }
        public bool Encode { get; set; }
    }
}
