using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PricingItemPrice : BaseEntity
    {
          
 
		public Int32 PricingItemPriceID { get; set; }  
 
		public Int32 InventoryPricingRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Decimal TotalPrice { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


