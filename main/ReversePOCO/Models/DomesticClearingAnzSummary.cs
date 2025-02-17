using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingAnzSummary
    {
        public int AnzSummaryId { get; set; }
        public DateTime? ProcessDate { get; set; }
        public DateTime? ValueDate { get; set; }
        public string Description { get; set; }
        public int? DebitQuantity { get; set; }
        public decimal? DebitValue { get; set; }
        public int? CreditQuantity { get; set; }
        public decimal? CreditValue { get; set; }
        public decimal? TotalValueOfTransactions { get; set; }
        public string Direction { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public DateTime CreatedWhen { get; set; }
        public string Filename { get; set; }
    }
}
