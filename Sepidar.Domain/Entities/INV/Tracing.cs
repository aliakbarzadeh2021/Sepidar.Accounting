using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Tracing : BaseEntity
    {
          
 
		public Int32 TracingID { get; set; }  
 
		public Int32 TracingCategoryRef { get; set; }  
 
		public String Title { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


