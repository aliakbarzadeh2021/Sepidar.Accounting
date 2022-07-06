using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class DailyHourMinute : BaseEntity
    {
          
 
		public Int32 DailyHourMinuteId { get; set; }  
 
		public Int32 PayrollConfigurationRef { get; set; }  
 
		public Int32 Year { get; set; }  
 
		public Int32 DailyHourMinute1 { get; set; } 
    }
}


