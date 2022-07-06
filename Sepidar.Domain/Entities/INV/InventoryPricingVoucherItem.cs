using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class InventoryPricingVoucherItem : BaseEntity
    {
          
 
		public Int32 InventoryPricingVoucherItemID { get; set; }  
 
		public Int32 InventoryPricingVoucherRef { get; set; }  
 
		public Int32 InventoryVoucherItemRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


