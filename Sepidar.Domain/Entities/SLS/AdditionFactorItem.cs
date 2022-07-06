using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class AdditionFactorItem : BaseEntity
    {
          
 
		public Int32 AdditionFactorItemID { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal FromValue { get; set; }  
 
		public Decimal ToValue { get; set; }  
 
		public Int32 AdditionType { get; set; }  
 
		public Decimal Amount { get; set; } 
    }
}


