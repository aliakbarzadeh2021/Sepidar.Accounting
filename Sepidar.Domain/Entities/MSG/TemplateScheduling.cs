using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class TemplateScheduling : BaseEntity
    {
          
 
		public Int32 TemplateSchedulingID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public Int32 SchedulingRef { get; set; } 
    }
}


