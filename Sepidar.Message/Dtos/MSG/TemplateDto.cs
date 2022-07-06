using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class TemplateDto
    {
          
 
		public Int32 TemplateID { get; set; }  
 
		public Guid TemplateGUID { get; set; }  
 
		public Boolean IsSystemTemplate { get; set; }  
 
		public Int32 TemplateVersion { get; set; }  
 
		public String Title { get; set; }  
 
		public String Body { get; set; }  
 
		public Boolean ShowOutgoingMessage { get; set; }  
 
		public String MessageParameterInfoFullName { get; set; }  
 
		public Nullable<Int32> FilterMedianOperator { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}


