using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class SystemSetting
    {
        public int SettingId { get; set; }
        public string SystemName { get; set; }
        public string SettingGroup { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
    }
}
