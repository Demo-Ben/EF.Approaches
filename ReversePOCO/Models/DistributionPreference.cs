using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DistributionPreference
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerBranch { get; set; }
        public string CustomerAbbr { get; set; }
        public int DistributionType { get; set; }
        public int DistributionChannel { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public string AuthorisedBy { get; set; }
        public DateTime? AuthorisedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual DistributionChannel DistributionChannelNavigation { get; set; }
        public virtual DistributionType DistributionTypeNavigation { get; set; }
    }
}
