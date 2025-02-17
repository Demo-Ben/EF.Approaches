using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class FxfcustBakMurexRelease
    {
        public int CustId { get; set; }
        public string Code { get; set; }
        public string Shortname { get; set; }
        public string Abbreviation { get; set; }
        public string Ibosno { get; set; }
        public string Branch { get; set; }
        public int? ParentEntityId { get; set; }
        public string Location { get; set; }
        public string Notes { get; set; }
        public int? Active { get; set; }
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string AddBy { get; set; }
        public DateTime AddOn { get; set; }
        public string ModifyBy { get; set; }
        public string DeleteBy { get; set; }
        public DateTime DeleteOn { get; set; }
        public DateTime ModifyOn { get; set; }
        public string AuthorizeBy { get; set; }
        public DateTime AuthorizeOn { get; set; }
        public string CallDepositAudType { get; set; }
        public string CallDepositFgnType { get; set; }
        public string CallLoanAudType { get; set; }
        public string CallLoanFgnType { get; set; }
        public string Description { get; set; }
        public string Ccif { get; set; }
        public string DeptCode { get; set; }
        public string TaxCode { get; set; }
        public string Category { get; set; }
        public string Sector { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Street3 { get; set; }
        public string Street4 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Telex { get; set; }
        public string Swift { get; set; }
        public string Email { get; set; }
        public int? ParentId { get; set; }
        public int? MxGuideCustDetailId { get; set; }
    }
}
