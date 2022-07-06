using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommunicationConfiguration : BaseEntity
    {
          
 
		public Int32 CommunicationConfigurationID { get; set; }  
 
		public Int32 System { get; set; }  
 
		public String Key { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


