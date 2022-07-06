using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CustomContactPhone : BaseEntity
    {
          
 
		public Int32 CustomContactPhoneId { get; set; }  
 
		public Int32 CustomContactRef { get; set; }  
 
		public String Phone { get; set; }  
 
		public Boolean IsMain { get; set; } 
    }
}


