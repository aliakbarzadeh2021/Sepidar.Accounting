using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ItemAdditionFactor : BaseEntity
    {
          
 
		public Int32 ItemAdditionFactorID { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; } 
    }
}


