using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class SchedulingItem : BaseEntity
    {
          
 
		public Int32 SchedulingItemId { get; set; }  
 
		public Int32 SchedulingRef { get; set; }  
 
		public DateTime DateTime { get; set; } 
    }
}


