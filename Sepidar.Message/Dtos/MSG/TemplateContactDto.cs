using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class TemplateContactDto
    {
          
 
		public Int32 TemplateContactID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public String Phone { get; set; }  
 
		public Nullable<Int32> ContactPhoneRef { get; set; }  
 
		public Nullable<Int32> ContactType { get; set; }  
 
		public String ParameterName { get; set; } 
    }
}


