using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class SentScheduledTemplateSchedulingDate : BaseEntity
    {
          
 
		public Int32 SentScheduledTemplateSchedulingDateID { get; set; }  
 
		public Int32 TemplateSchedulingRef { get; set; }  
 
		public Int32 SchedulingItemRef { get; set; } 
    }
}


