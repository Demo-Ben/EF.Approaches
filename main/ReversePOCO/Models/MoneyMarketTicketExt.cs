using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MoneyMarketTicketExt
    {
        public int MmticketId { get; set; }
        public string AddBy { get; set; }
        public DateTime? AddOn { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime? AuthorizeOn { get; set; }
        public string VerifyBy { get; set; }
        public DateTime? VerifyOn { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyOn { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteOn { get; set; }
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string GipStatus { get; set; }
        public string GipDescription { get; set; }
        public string TranNo { get; set; }
        public string GbaseDump { get; set; }

        public virtual MoneyMarketTicket Mmticket { get; set; }
    }
}
