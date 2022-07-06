using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class TemplateFilterDto
    {
          
 
		public Int32 TemplateFilterID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public String ParameterName { get; set; }  
 
		public Int32 FilterCondition { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Operator { get; set; } 
    }
}


