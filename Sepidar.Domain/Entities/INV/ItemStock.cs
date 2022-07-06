using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ItemStock : BaseEntity
    {
          
 
		public Int32 ItemStockID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


