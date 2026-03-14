using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class DataDrivenSubscriptionSetting
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Alias { get; set; }
        public string EmailAddress { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public string RenderFormat { get; set; }
        public string ReportInclude { get; set; }
        public string Linked { get; set; }
        public bool? FileExtn { get; set; }
        public string WriteMode { get; set; }
        public string Subject { get; set; }
        public string Comments { get; set; }
        public bool? EndOfDay { get; set; }
        public bool? PwExpired { get; set; }
    }
}
