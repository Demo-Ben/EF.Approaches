using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class SecurityGroup
    {
        public decimal Identifier { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EnabledInd { get; set; }
        public DateTime CreatedAmendedDate { get; set; }
    }
}
