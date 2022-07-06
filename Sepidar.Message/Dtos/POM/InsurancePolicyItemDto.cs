using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InsurancePolicyItemDto
    {
          
 
		public Int32 InsurancePolicyItemID { get; set; }  
 
		public Int32 InsurancePolicyRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 BasePurchaseOrderItemRef { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Nullable<Decimal> PriceInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


