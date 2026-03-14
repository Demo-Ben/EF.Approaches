using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecKeyStatu
    {
        public DomesticClearingRecKeyStatu()
        {
            DomesticClearingRecRecGoes = new HashSet<DomesticClearingRecRecGo>();
            DomesticClearingRecRecInwardClearings = new HashSet<DomesticClearingRecRecInwardClearing>();
            DomesticClearingRecRecPaymentCreations = new HashSet<DomesticClearingRecRecPaymentCreation>();
            DomesticClearingRecRecPayments = new HashSet<DomesticClearingRecRecPayment>();
        }

        public int RecKeyStatusId { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual ICollection<DomesticClearingRecRecGo> DomesticClearingRecRecGoes { get; set; }
        public virtual ICollection<DomesticClearingRecRecInwardClearing> DomesticClearingRecRecInwardClearings { get; set; }
        public virtual ICollection<DomesticClearingRecRecPaymentCreation> DomesticClearingRecRecPaymentCreations { get; set; }
        public virtual ICollection<DomesticClearingRecRecPayment> DomesticClearingRecRecPayments { get; set; }
    }
}
