using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlSwiftAck
    {
        public int SwiftAckId { get; set; }
        public string MessageNo { get; set; }
        public string HostMessageNo { get; set; }
        public DateTime? SendDate { get; set; }
        public TimeSpan? AuthorisedTime { get; set; }
        public string MessageType { get; set; }
        public string Mx { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public string ReceiverBankCode1 { get; set; }
        public string ReceiverBankCode2 { get; set; }
        public string ReceiverSwiftAddress { get; set; }
        public string ReceiverBankName { get; set; }
        public string ReceiverBranchCity { get; set; }
        public string OurRefNo { get; set; }
        public string TheirRefNo { get; set; }
        public string Reference { get; set; }
        public string BeneficiaryCustomerBank { get; set; }
        public string SectionNo { get; set; }
        public string SectionName { get; set; }
        public string Group { get; set; }
        public string OutgoingStatus { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public int? SwiftPaymentId { get; set; }
        public int? PaymentId { get; set; }
        public bool Processed { get; set; }

        public virtual PaymentControlPayment Payment { get; set; }
        public virtual PaymentControlSwiftPayment SwiftPayment { get; set; }
    }
}
