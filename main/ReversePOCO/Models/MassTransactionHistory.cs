using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MassTransactionHistory
    {
        public decimal TranId { get; set; }
        public decimal BatchRefNo { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public string ModuleId { get; set; }
        public string AcuBuInd { get; set; }
        public string TranNumber { get; set; }
        public string GbaseRefCode { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string OperationMode { get; set; }
        public string ReapprovedOverrideBy { get; set; }
        public DateTime? ReapprovedOverrideDate { get; set; }
        public string MinNo { get; set; }
    }
}
