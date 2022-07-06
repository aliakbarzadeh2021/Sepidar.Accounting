using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class UserAccess : BaseEntity
    {
          
 
		public Int32 UserAccessID { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public String LogicalResource { get; set; }  
 
		public Boolean HasAccess { get; set; } 
    }
}


