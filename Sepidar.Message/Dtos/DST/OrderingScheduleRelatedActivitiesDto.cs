using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class OrderingScheduleRelatedActivitiesDto
    {
          
 
		public Int32 OrderingScheduleRelatedActivitiesId { get; set; }  
 
		public Int64 ScheduleId { get; set; }  
 
		public Nullable<Int32> OrderRef { get; set; }  
 
		public Nullable<Int32> OrderingFailureItemRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


