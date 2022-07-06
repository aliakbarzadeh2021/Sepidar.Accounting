using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class UserPhone : BaseEntity
    {
          
 
		public Int32 UserPhoneId { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Phone { get; set; }  
 
		public Boolean IsMain { get; set; } 
    }
}


