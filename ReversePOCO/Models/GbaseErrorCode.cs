using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GbaseErrorCode
    {
        public string ErrorCode { get; set; }
        public string ShortDesc { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
