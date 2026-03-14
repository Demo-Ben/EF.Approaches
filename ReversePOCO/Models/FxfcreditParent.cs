using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class FxfcreditParent
    {
        public int Id { get; set; }
        public int? CustTypeId { get; set; }
        public string CorpNo { get; set; }
        public string Cif { get; set; }
        public string Name { get; set; }
        public int? Active { get; set; }
        public string Description { get; set; }
        public string Ibosno { get; set; }
        public string Code { get; set; }
        public bool SamedayFx { get; set; }
        public bool DepositAlm { get; set; }
    }
}
