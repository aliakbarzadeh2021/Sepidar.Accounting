using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ItemDiscountDto
    {
          
 
		public Int32 ItemDiscountID { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; } 
    }
}


