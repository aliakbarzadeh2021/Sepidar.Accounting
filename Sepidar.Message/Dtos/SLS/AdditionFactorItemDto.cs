using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class AdditionFactorItemDto
    {
          
 
		public Int32 AdditionFactorItemID { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal FromValue { get; set; }  
 
		public Decimal ToValue { get; set; }  
 
		public Int32 AdditionType { get; set; }  
 
		public Decimal Amount { get; set; } 
    }
}


