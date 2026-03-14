using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MassGbaseMenuAccess
    {
        public string ModuleId { get; set; }
        public string MenuSection { get; set; }
        public string SectionDesc { get; set; }
        public string SourceTableName { get; set; }
        public string SourceTableUpdateFlag { get; set; }
        public string ApprovalQueryStatus { get; set; }
        public string ApprovalSuccessStatus { get; set; }
        public string ApprovalFailureStatus { get; set; }
        public string ActiveInd { get; set; }
        public string Remarks { get; set; }
        public string UpdateColForStatus { get; set; }
        public string UpdateColForDesc { get; set; }
        public string WhereColForTranNo { get; set; }
        public string WhereColForRefNo { get; set; }
        public string WhereColForAppBy { get; set; }
        public string WhereColForAppDt { get; set; }
        public string MassModuleFlag { get; set; }
        public string WhereColForMinNo { get; set; }
    }
}
