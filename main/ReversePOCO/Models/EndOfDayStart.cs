using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class EndOfDayStart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string VerifiedWho { get; set; }
        public DateTime? VerifiedWhen { get; set; }
        public string AuthorisedWho { get; set; }
        public DateTime? AuthorisedWhen { get; set; }
        public DateTime CreatedWhen { get; set; }
        public DateTime UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
    }
}
