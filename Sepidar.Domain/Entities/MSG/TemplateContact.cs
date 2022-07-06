using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class TemplateContact : BaseEntity
    {
          
 
		public Int32 TemplateContactID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public String Phone { get; set; }  
 
		public Nullable<Int32> ContactPhoneRef { get; set; }  
 
		public Nullable<Int32> ContactType { get; set; }  
 
		public String ParameterName { get; set; } 
    }
}


