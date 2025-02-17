using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GasTemplate
    {
        public string TemplateName { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string AcuBu { get; set; }
        public string Remarks { get; set; }
        public string BackValue { get; set; }
        public string Reason { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string Status { get; set; }
    }
}
