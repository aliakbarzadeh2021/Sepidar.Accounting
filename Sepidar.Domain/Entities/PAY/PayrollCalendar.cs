using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PayrollCalendar : BaseEntity
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


