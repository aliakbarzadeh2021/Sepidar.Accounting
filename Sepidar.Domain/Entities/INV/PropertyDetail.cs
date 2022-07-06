using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PropertyDetail : BaseEntity
    {
          
 
		public Int32 PropertyDetailID { get; set; }  
 
		public String Title { get; set; }  
 
		public Int32 PropertyRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


