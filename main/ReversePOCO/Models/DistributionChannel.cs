using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DistributionChannel
    {
        public DistributionChannel()
        {
            DistributionPreferences = new HashSet<DistributionPreference>();
        }

        public int Id { get; set; }
        public string Channel { get; set; }

        public virtual ICollection<DistributionPreference> DistributionPreferences { get; set; }
    }
}
