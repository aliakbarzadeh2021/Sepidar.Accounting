using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class InventoryPricing : BaseEntity
    {
          
 
		public Int32 InventoryPricingID { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public DateTime EndDate { get; set; }  
 
		public Int32 Inputs { get; set; }  
 
		public Int32 Outputs { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


