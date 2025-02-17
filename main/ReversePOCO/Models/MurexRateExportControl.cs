using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MurexRateExportControl
    {
        public int Id { get; set; }
        public DateTime? DataDate { get; set; }
        public bool? Run { get; set; }
    }
}
