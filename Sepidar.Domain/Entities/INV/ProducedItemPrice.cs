using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ProducedItemPrice : BaseEntity
    {
          
 
		public Int32 ProducedItemPriceID { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Decimal> Price { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


