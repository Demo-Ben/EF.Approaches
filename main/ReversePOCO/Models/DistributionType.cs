using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DistributionType
    {
        public DistributionType()
        {
            DistributionPreferences = new HashSet<DistributionPreference>();
        }

        public int Id { get; set; }
        public string DistributionType1 { get; set; }
        public string VisableToSystem { get; set; }
        public string DefaultDistributionStatus { get; set; }
        public string TemplateName { get; set; }

        public virtual ICollection<DistributionPreference> DistributionPreferences { get; set; }
    }
}
