using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class InventoryPricingVoucher : BaseEntity
    {
          
 
		public Int32 InventoryPricingVoucherID { get; set; }  
 
		public Int32 InventoryPricingRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 InventoryVoucherType { get; set; }  
 
		public Int32 InventoryVoucherRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


