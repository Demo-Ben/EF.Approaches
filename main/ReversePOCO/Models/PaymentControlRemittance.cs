using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class PaymentControlRemittance
    {
        public int RemittanceId { get; set; }
        public string GbaseRefNo { get; set; }
        public string Status { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? Podate { get; set; }
        public DateTime? ValueDate { get; set; }
        public string CustomerAccount { get; set; }
        public string CustomerAbbreviation { get; set; }
        public string CustomerName { get; set; }
        public string Department { get; set; }
        public string InstructedCurrency { get; set; }
        public string InstructedAmount { get; set; }
        public string PendingNo { get; set; }
        public string PendingReason { get; set; }
        public string ExRate { get; set; }
        public string AccountNo { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string BeneficiaryAccount { get; set; }
        public string RemitterBeneficiary1 { get; set; }
        public string RemitterBeneficiary2 { get; set; }
        public string NostroId { get; set; }
        public string NostroName { get; set; }
        public string ReceivingBankSbic { get; set; }
        public string AccountWithBankSbic { get; set; }
        public string AccountWithBankAc { get; set; }
        public string AccountWithBank1 { get; set; }
        public string DetailsOfChgs { get; set; }
        public string SenderToReceiverInfo1 { get; set; }
        public string RemarkTypeofApp { get; set; }
        public string RemarkSupportingDoc { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string DeleteDate { get; set; }
        public string ApplicationNo { get; set; }
        public string RemarksEuc { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual PaymentControlPayment Payment { get; set; }
    }
}
