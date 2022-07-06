using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PayrollCalendarDto
    {
          
 
		public Int32 PayrollCalendarId { get; set; }  
 
		public Int32 Year { get; set; }  
 
		public Int32 Month { get; set; }  
 
		public Nullable<Int32> Day { get; set; }  
 
		public Nullable<Int32> HourMinute { get; set; }  
 
		public Nullable<Int32> TotalHourMinute { get; set; }  
 
		public Int32 PayrollConfigurationRef { get; set; } 
    }
}


