using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommercialOrderItem : BaseEntity
    {
          
 
		public Int32 CommercialOrderItemID { get; set; }  
 
		public Int32 CommercialOrderRef { get; set; }  
 
		public Int32 PurchaseOrderItemRef { get; set; }  
 
		public Nullable<Decimal> RegisterFee { get; set; }  
 
		public Int32 RowNumber { get; set; } 
    }
}


