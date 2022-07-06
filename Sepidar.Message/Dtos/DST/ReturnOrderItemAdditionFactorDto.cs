using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ReturnOrderItemAdditionFactorDto
    {
          
 
		public Int32 ReturnOrderItemAdditionFactorID { get; set; }  
 
		public Int32 ReturnOrderItemRef { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal Value { get; set; }  
 
		public Decimal ValueInBaseCurrency { get; set; } 
    }
}


