using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DealingSettlementOfficeMap
    {
        public int DealingSettlementOfficeId { get; set; }
        public string DealingOfficeCode { get; set; }
        public string DealingOfficeName { get; set; }
        public string DealingOfficeLocation { get; set; }
        public string SettlementOfficeCode { get; set; }
        public bool? Active { get; set; }
        public string DealingSystem { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
