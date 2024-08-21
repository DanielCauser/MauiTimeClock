using System;
namespace ArisTimeClock.Models
{
	public class ManualClockEventGridModel
	{
        public string Time { get; set; }
        public string Date { get; set; }
        public string ClockStatus { get; set; }
        public string Reason { get; set; }
        public string EmployeeNumber { get; set; }
        public string Response { get; set; }
    }
}

