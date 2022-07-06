using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ProductOrderBOMItemDto
    {
          
 
		public Int32 ProductOrderBOMItemID { get; set; }  
 
		public Int32 ProductOrderRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> FormulaBOMItemRef { get; set; }  
 
		public Nullable<Decimal> StandardConsumptionQuantity { get; set; }  
 
		public Nullable<Decimal> RemainingConsumptionQuantity { get; set; }  
 
		public String Description { get; set; }  
 
		public Nullable<Decimal> TransferedQuantity { get; set; } 
    }
}


