using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GeneralisedCode
    {
        public string Type { get; set; }
        public string Code { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAmendedDate { get; set; }
    }
}
