using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class DiscountItemDto
    {
          
 
		public Int32 DiscountItemID { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Decimal FromValue { get; set; }  
 
		public Decimal ToValue { get; set; }  
 
		public Nullable<Int32> DiscountType { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<Int32> ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Int32> ProductPackRef { get; set; } 
    }
}


