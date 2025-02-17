using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectGoEuconDemandLogCommon
    {
        public int RecCollectGoeuconDemandLogCommonId { get; set; }
        public int RecCollectionId { get; set; }
        public DateTime? DataDate { get; set; }
        public string BranchNo { get; set; }
        public string TransNo { get; set; }
        public string SeqNo { get; set; }
        public string IbfId { get; set; }
        public string DepartmentCd { get; set; }
        public string RefNo { get; set; }
        public string DdNo { get; set; }
        public string RoNo { get; set; }
        public string OnlineCd { get; set; }
        public string OpeKind { get; set; }
        public string InputEmpCd { get; set; }
        public string InputOpeId { get; set; }
        public string ApproveEmpCd { get; set; }
        public string ApproveOpeId { get; set; }
        public DateTime? ValueDate { get; set; }
        public string IrregularTransFlg { get; set; }
        public string Remarks { get; set; }
        public string TerminalId { get; set; }
        public DateTime? OrgTransOpeDate { get; set; }
        public string OrgTransNo { get; set; }
        public string OrgTransOnlineCd { get; set; }
        public string CorrectFlg { get; set; }
        public string TransTime { get; set; }
        public string DeleteTime { get; set; }
        public string ApproveTime { get; set; }
        public string ApproveFlg { get; set; }
        public string DeleteFlg { get; set; }
        public string RecoveryFlg { get; set; }
        public string CustAbbr { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string CcyCode { get; set; }
        public string CcyAbbr { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? DdValueDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string Days { get; set; }
        public decimal? IntRate { get; set; }
        public decimal? IntAmount { get; set; }
        public string PrevCcyCode { get; set; }
        public string PrevCcyAbbr { get; set; }
        public decimal? PrevAmount { get; set; }
        public DateTime? PrevValueDate { get; set; }
        public DateTime? PrevDueDate { get; set; }
        public string PrevDays { get; set; }
        public decimal? PrevIntRate { get; set; }
        public decimal? PrevIntAmount { get; set; }
        public string DiscountFlg { get; set; }
        public string IntPayerFlg { get; set; }
        public DateTime? FinalDueDate { get; set; }
        public string CrtDate { get; set; }
        public DateTime? Updatedate { get; set; }
        public int? BatchNumber { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
