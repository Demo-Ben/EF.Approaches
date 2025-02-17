using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectGoEuconDemandLogAccount
    {
        public int RecCollectGoeuconDemandLogAccountId { get; set; }
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
        public string IbfId2 { get; set; }
        public string ActId { get; set; }
        public string DrCr { get; set; }
        public string ActType { get; set; }
        public string ActCd { get; set; }
        public string ActAbbr { get; set; }
        public string CustAbbr { get; set; }
        public string RefNo2 { get; set; }
        public string CcyCode { get; set; }
        public string CcyAbbr { get; set; }
        public decimal? AmountFc { get; set; }
        public decimal? ConversionRate { get; set; }
        public decimal? AmountBc { get; set; }
        public decimal? EquivCcyAmount { get; set; }
        public string EquivCcyCd { get; set; }
        public decimal? EquivRate { get; set; }
        public string CheckNo { get; set; }
        public string AvailabilityFlg { get; set; }
        public DateTime? AvailableDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string LastTransNo { get; set; }
        public string CustLiabAccount { get; set; }
        public string ProgramNo { get; set; }
        public string SegmentType { get; set; }
        public string OdFlg { get; set; }
        public string TransCd { get; set; }
        public string RoNo2 { get; set; }
        public string IntPayerCountry { get; set; }
        public string RemarksFlg { get; set; }
        public string PaFlg { get; set; }
        public string UpdateFlg { get; set; }
        public string NoUpdateFlg { get; set; }
        public string CrtDate { get; set; }
        public DateTime? Updatedate { get; set; }
        public int? BatchNumber { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
