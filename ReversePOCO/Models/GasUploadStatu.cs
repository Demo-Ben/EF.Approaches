using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GasUploadStatu
    {
        public string FileType { get; set; }
        public string UploadCode { get; set; }
        public string UploadTag { get; set; }
        public string DescriptionTx { get; set; }
    }
}
