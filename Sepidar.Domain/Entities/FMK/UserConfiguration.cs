using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class UserConfiguration : BaseEntity
    {
          
 
		public Int32 UserConfigurationID { get; set; }  
 
		public String Key { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


