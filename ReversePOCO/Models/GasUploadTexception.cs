using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class GasUploadTexception
    {
        public DateTime LogdateDt { get; set; }
        public string MinnoTx { get; set; }
        public string GroupnoTx { get; set; }
        public string MainmoduleTx { get; set; }
        public string FunctionTx { get; set; }
        public string DescriptionTx { get; set; }
        public string LogidTx { get; set; }
        public string SequencenoTx { get; set; }
    }
}
