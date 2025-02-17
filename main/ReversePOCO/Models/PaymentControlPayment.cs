using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlPayment
    {
        public PaymentControlPayment()
        {
            PaymentControlAccordConfirmations = new HashSet<PaymentControlAccordConfirmation>();
            PaymentControlMatchFxes = new HashSet<PaymentControlMatchFx>();
            PaymentControlMatchMoneyMarkets = new HashSet<PaymentControlMatchMoneyMarket>();
            PaymentControlMisysConfirmations = new HashSet<PaymentControlMisysConfirmation>();
            PaymentControlPaymentLogs = new HashSet<PaymentControlPaymentLog>();
            PaymentControlRemittances = new HashSet<PaymentControlRemittance>();
            PaymentControlSwiftAcks = new HashSet<PaymentControlSwiftAck>();
            PaymentControlSwiftPayments = new HashSet<PaymentControlSwiftPayment>();
        }

        public int PaymentId { get; set; }
        public string GbaseRefNo { get; set; }
        public DateTime? ValueDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string PaymentCurrencyCode { get; set; }
        public decimal? PaymentAmount { get; set; }
        public int? ProductReferenceId { get; set; }
        public int? StatusId { get; set; }
        public string CustomerAbbreviation { get; set; }
        public bool? WaitingPayment { get; set; }
        public bool? WaitingSwiftPayment { get; set; }
        public bool? WaitingConfirmation { get; set; }
        public bool? WaitingAckNack { get; set; }
        public bool WasManual { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public DateTime? CreatedWhen { get; set; }
        public string CountryCode { get; set; }
        public int? PreviousStatusId { get; set; }

        public virtual PaymentControlProductReference ProductReference { get; set; }
        public virtual PaymentControlStatu Status { get; set; }
        public virtual ICollection<PaymentControlAccordConfirmation> PaymentControlAccordConfirmations { get; set; }
        public virtual ICollection<PaymentControlMatchFx> PaymentControlMatchFxes { get; set; }
        public virtual ICollection<PaymentControlMatchMoneyMarket> PaymentControlMatchMoneyMarkets { get; set; }
        public virtual ICollection<PaymentControlMisysConfirmation> PaymentControlMisysConfirmations { get; set; }
        public virtual ICollection<PaymentControlPaymentLog> PaymentControlPaymentLogs { get; set; }
        public virtual ICollection<PaymentControlRemittance> PaymentControlRemittances { get; set; }
        public virtual ICollection<PaymentControlSwiftAck> PaymentControlSwiftAcks { get; set; }
        public virtual ICollection<PaymentControlSwiftPayment> PaymentControlSwiftPayments { get; set; }
    }
}
