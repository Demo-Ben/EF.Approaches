using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class Fxfarbitrage
    {
        public int Id { get; set; }
        public string SchemeNo { get; set; }
        public DateTime? Contractdate { get; set; }
        public DateTime? ValueDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string Remarks { get; set; }
        public string TakePrinCcy { get; set; }
        public double? TakePrinAmt { get; set; }
        public double? TakeIntRate { get; set; }
        public double? TakeIntAmount { get; set; }
        public short? TakeDaysAyear { get; set; }
        public string LendPrinCcy { get; set; }
        public double? LendPrinAmt { get; set; }
        public double? LendIntRate { get; set; }
        public double? LendIntAmount { get; set; }
        public short? LendDaysAyear { get; set; }
        public string SpotBghCcy { get; set; }
        public double? SpotBghAmt { get; set; }
        public double? SpotExRate { get; set; }
        public string SpotSoldCcy { get; set; }
        public double? SpotSoldAmt { get; set; }
        public string FwdbghCcy { get; set; }
        public double? FwdbghAmt { get; set; }
        public double? FwdexRate { get; set; }
        public string FwdsoldCcy { get; set; }
        public double? FwdsoldAmt { get; set; }
        public string IfwdBghCcy { get; set; }
        public double? IfwdBghAmt { get; set; }
        public double? IfwdExRate { get; set; }
        public string IfwdSoldCcy { get; set; }
        public double? IfwdSoldAmt { get; set; }
        public string Ibf { get; set; }
        public byte Upload { get; set; }
        public bool Printed { get; set; }
        public DateTime? Printdate { get; set; }
        public DateTime? Printtime { get; set; }
        public string FixedCurrency { get; set; }
    }
}
