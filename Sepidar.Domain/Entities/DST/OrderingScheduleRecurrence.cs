using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class OrderingScheduleRecurrence : BaseEntity
    {
          
 
		public Int32 OrderingScheduleRecurrenceId { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public DateTime EndDate { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> DayInterval { get; set; }  
 
		public Nullable<Int32> WeekInterval { get; set; }  
 
		public Nullable<Int32> Weekdays { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


