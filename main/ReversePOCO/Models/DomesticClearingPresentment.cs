using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingPresentment
    {
        public int PresentmentId { get; set; }
        public DateTime? TransmissionDate { get; set; }
        public decimal? Amount { get; set; }
        public string DrawerAccountNo { get; set; }
        public string BsbledgerFi { get; set; }
        public string BsbcapturingFi { get; set; }
        public string BsbcollectingFi { get; set; }
        public string TransactionIdentifier { get; set; }
        public string AuxillaryDomestic { get; set; }
        public bool Processed { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime? CreatedWhen { get; set; }
        public int? PaymentId { get; set; }
        public string Filename { get; set; }
        public string BsbDepositorsNominatedFi { get; set; }
        public string DepositorNominatedAccountNumber { get; set; }
        public string ExtraAuxiliaryDomestic { get; set; }
        public string CaptureDeviceIdentifier { get; set; }
        public string VoucherIndicator { get; set; }
        public string ManualRepair { get; set; }
        public string TransactionCode { get; set; }
        public string BsbsendingFi { get; set; }
        public string BsbreceivingFi { get; set; }

        public virtual DomesticClearingPayment Payment { get; set; }
    }
}
