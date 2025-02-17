using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlRtgsSwiftCodeTranslation
    {
        public int RtgsSwiftCodeTranslationId { get; set; }
        public string Name { get; set; }
        public string SwiftCode { get; set; }
        public string RtgsBic { get; set; }
        public string Bsb { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
    }
}
