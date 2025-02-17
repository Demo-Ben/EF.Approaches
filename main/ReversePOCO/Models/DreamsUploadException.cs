using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DreamsUploadException
    {
        public decimal ExceptionId { get; set; }
        public DateTime ExceptionDate { get; set; }
        public string UploadType { get; set; }
        public string RecordId { get; set; }
        public string UploadError { get; set; }
    }
}
