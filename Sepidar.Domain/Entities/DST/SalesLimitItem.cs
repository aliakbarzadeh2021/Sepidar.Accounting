using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class SalesLimitItem : BaseEntity
    {
          
 
		public Int32 SalesLimitItemId { get; set; }  
 
		public Int32 SalesLimitRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; } 
    }
}


