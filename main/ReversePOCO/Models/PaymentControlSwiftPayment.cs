using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlSwiftPayment
    {
        public PaymentControlSwiftPayment()
        {
            PaymentControlSwiftAcks = new HashSet<PaymentControlSwiftAck>();
            PaymentControlSwiftPaymentLogs = new HashSet<PaymentControlSwiftPaymentLog>();
        }

        public int SwiftPaymentId { get; set; }
        public string Payment { get; set; }
        public bool IsRtgs { get; set; }
        public string MessageType { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        public int? StatusId { get; set; }
        public string GbaseRefNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public int? ProductReferenceId { get; set; }
        public string SenderBank { get; set; }
        public string ReceiverBank { get; set; }
        public string BeneficiaryAccount { get; set; }
        public string BeneficiaryCustomer { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public bool HasOther { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual PaymentControlPayment PaymentNavigation { get; set; }
        public virtual PaymentControlProductReference ProductReference { get; set; }
        public virtual PaymentControlStatu Status { get; set; }
        public virtual ICollection<PaymentControlSwiftAck> PaymentControlSwiftAcks { get; set; }
        public virtual ICollection<PaymentControlSwiftPaymentLog> PaymentControlSwiftPaymentLogs { get; set; }
    }
}
