using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class OrderingScheduleRelatedActivities : BaseEntity
    {
          
 
		public Int32 OrderingScheduleRelatedActivitiesId { get; set; }  
 
		public Int64 ScheduleId { get; set; }  
 
		public Nullable<Int32> OrderRef { get; set; }  
 
		public Nullable<Int32> OrderingFailureItemRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


