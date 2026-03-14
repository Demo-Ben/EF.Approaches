using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class FxfcreditCustType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Active { get; set; }
    }
}
