using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PasswordHistory
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public DateTime PwdChangeDt { get; set; }
        public string SecurityFlag { get; set; }
    }
}
