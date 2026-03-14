using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class Result
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EmployeeNo { get; set; }
        public decimal? SgIdentifier { get; set; }
        public string Role { get; set; }
        public string EnabledInd { get; set; }
        public DateTime PwdCreateDate { get; set; }
        public string PwdChangeInd { get; set; }
        public DateTime CreatedAmendedDate { get; set; }
        public string DeptCode { get; set; }
        public string RecStatus { get; set; }
        public string OperatorId { get; set; }
        public string RankCode { get; set; }
        public string BuStatusCode { get; set; }
        public string AcuStatusCode { get; set; }
        public string SubDeptCode { get; set; }
        public string CreatedAmendedBy { get; set; }
        public DateTime? GbaseUploadedDate { get; set; }
        public string GbaseStatusCode { get; set; }
        public string RacfStatusCode { get; set; }
        public string RacfPreviousPwd { get; set; }
        public decimal? NoOfLoginAttempts { get; set; }
        public string GbasePreviousPwd { get; set; }
        public string GbasePwdBuStatusCode { get; set; }
        public string GbasePwdAcuStatusCode { get; set; }
        public string GbasePwdStatusCode { get; set; }
        public string MasterId { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string UserProfileStatus { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime? GbaseRegDate { get; set; }
        public DateTime? GbaseModiDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ProfileEditedBy { get; set; }
        public DateTime? ProfileEditedDate { get; set; }
        public string ResetBy { get; set; }
        public DateTime? ResetDate { get; set; }
        public Guid? Rowid { get; set; }
    }
}
