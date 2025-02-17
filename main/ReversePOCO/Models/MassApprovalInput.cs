using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MassApprovalInput
    {
        public decimal Identifier { get; set; }
        public string AcuBuInd { get; set; }
        public string StartTranNumber { get; set; }
        public string EndTranNumber { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string SectionCode { get; set; }
        public string Status { get; set; }
    }
}
