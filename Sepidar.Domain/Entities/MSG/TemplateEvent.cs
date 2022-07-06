using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class TemplateEvent : BaseEntity
    {
          
 
		public Int32 TemplateEventID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public String EventKey { get; set; } 
    }
}


