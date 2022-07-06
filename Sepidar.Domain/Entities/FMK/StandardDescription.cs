using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class StandardDescription : BaseEntity
    {
          
 
		public Int32 StandardDescriptionId { get; set; }  
 
		public String EntityTypeName { get; set; }  
 
		public Int32 Key { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


