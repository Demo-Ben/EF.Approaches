using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class MurexHolidayCalendar
    {
        public string Currency { get; set; }
        public string CalendarLabel { get; set; }
        public string CalendarDesc { get; set; }
        public DateTime HolidayDate { get; set; }
        public string HolidayDesc { get; set; }
    }
}
