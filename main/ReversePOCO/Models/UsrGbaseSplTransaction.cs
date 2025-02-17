using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class UsrGbaseSplTransaction
    {
        public string UserId { get; set; }
        public string System { get; set; }
        public string Personnel { get; set; }
        public string ApprovalOfLoan { get; set; }
        public string EdpManager { get; set; }
        public string ApprovalOfCorrection { get; set; }
        public string AccountSettlement { get; set; }
        public string NonOnlineAcc { get; set; }
        public string ApprovalOfRemittance { get; set; }
        public string WarningCdOverrd { get; set; }
        public string ApprovalWarnCd { get; set; }
        public string ApprovalOfTmpod { get; set; }
        public string ApprovalLdgrMod { get; set; }
        public string TransmitOfOut { get; set; }
        public string TakeInPosting { get; set; }
        public string UpdateOfMessage { get; set; }
        public string ReversalOfOp { get; set; }
        public string ProfitManagement { get; set; }
        public string SynthLimitCont { get; set; }
        public string ApprovalOfOd { get; set; }
        public string FwdValueRemittance { get; set; }
    }
}
