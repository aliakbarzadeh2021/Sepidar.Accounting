using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CommercialOrderItemDto
    {
          
 
		public Int32 CommercialOrderItemID { get; set; }  
 
		public Int32 CommercialOrderRef { get; set; }  
 
		public Int32 PurchaseOrderItemRef { get; set; }  
 
		public Nullable<Decimal> RegisterFee { get; set; }  
 
		public Int32 RowNumber { get; set; } 
    }
}


