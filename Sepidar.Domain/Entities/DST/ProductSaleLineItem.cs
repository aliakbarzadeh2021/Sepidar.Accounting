using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ProductSaleLineItem : BaseEntity
    {
          
 
		public Int32 ProductSaleLineItemId { get; set; }  
 
		public Int32 ProductSaleLineRef { get; set; }  
 
		public Int32 ItemRef { get; set; } 
    }
}


