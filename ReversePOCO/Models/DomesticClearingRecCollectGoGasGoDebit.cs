using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DomesticClearingRecCollectGoGasGoDebit
    {
        public int RecCollectGogasGoDebitId { get; set; }
        public int RecCollectionId { get; set; }
        public string MinNo { get; set; }
        public string TypeTx { get; set; }
        public string GroupnoTx { get; set; }
        public DateTime? ValuedateDt { get; set; }
        public string DreamsRefCode { get; set; }
        public string RemarksTx { get; set; }
        public string BackvalueInd { get; set; }
        public string CcyTx { get; set; }
        public decimal? AmountAmt { get; set; }
        public string CustidTx { get; set; }
        public string AccCdTx { get; set; }
        public string AccnumTx { get; set; }
        public string DetailsTx { get; set; }
        public string AdviseprintTx { get; set; }
        public string FxccyTx { get; set; }
        public decimal? InterrateInt { get; set; }
        public decimal? ExchrateInt { get; set; }
        public string EntityTx { get; set; }
        public string DivisionTx { get; set; }
        public string DescriptionTx { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastEditedBy { get; set; }
        public DateTime? LastEditedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletionInd { get; set; }
        public string ReasonTx { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? UploadedDate { get; set; }
        public string ReversedBy { get; set; }
        public DateTime? ReversedDate { get; set; }
        public string TransnoTx { get; set; }
        public decimal? StatusInt { get; set; }
        public string AcubuTx { get; set; }
        public string PushFlag { get; set; }
        public string PushTxnFlag { get; set; }
        public DateTime? AvailableDate { get; set; }
        public string TranType { get; set; }
        public string BulkUploadInd { get; set; }
        public DateTime? ExportedDt { get; set; }
        public string ChecknoTx { get; set; }
        public string FundTx { get; set; }
        public decimal? SeqNo { get; set; }
        public string IbfTx { get; set; }
        public DateTime? UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }

        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
