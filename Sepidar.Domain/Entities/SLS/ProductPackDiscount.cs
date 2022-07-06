using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ProductPackDiscount : BaseEntity
    {
          
 
		public Int32 ProductPackDiscountID { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Nullable<Int32> ProductPackRef { get; set; } 
    }
}


