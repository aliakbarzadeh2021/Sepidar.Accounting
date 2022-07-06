using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class SalesLimitItemDto
    {
          
 
		public Int32 SalesLimitItemId { get; set; }  
 
		public Int32 SalesLimitRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; } 
    }
}


