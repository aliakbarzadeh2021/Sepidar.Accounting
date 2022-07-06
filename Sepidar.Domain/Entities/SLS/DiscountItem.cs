using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class DiscountItem : BaseEntity
    {
          
 
		public Int32 DiscountItemID { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Decimal FromValue { get; set; }  
 
		public Decimal ToValue { get; set; }  
 
		public Nullable<Int32> DiscountType { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<Int32> ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Int32> ProductPackRef { get; set; } 
    }
}


