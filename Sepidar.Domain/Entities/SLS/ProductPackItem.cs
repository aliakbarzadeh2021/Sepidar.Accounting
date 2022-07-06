using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ProductPackItem : BaseEntity
    {
          
 
		public Int32 ProductPackItemID { get; set; }  
 
		public Int32 ProductPackRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; } 
    }
}


