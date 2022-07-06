using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class TemplateFilter : BaseEntity
    {
          
 
		public Int32 TemplateFilterID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public String ParameterName { get; set; }  
 
		public Int32 FilterCondition { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Operator { get; set; } 
    }
}


