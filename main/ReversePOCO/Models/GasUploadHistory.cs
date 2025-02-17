using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GasUploadHistory
    {
        public string MinNo { get; set; }
        public string DreamsRefCode { get; set; }
        public decimal? Status { get; set; }
        public string TranNumber { get; set; }
        public string GroupNo { get; set; }
        public string DescriptionTx { get; set; }
        public string SequencenoTx { get; set; }
        public string UploadMode { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
