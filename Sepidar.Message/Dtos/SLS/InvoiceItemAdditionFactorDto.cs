using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InvoiceItemAdditionFactorDto
    {
          
 
		public Int32 InvoiceItemAdditionFactorID { get; set; }  
 
		public Int32 InvoiceItemRef { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal Value { get; set; }  
 
		public Decimal ValueInBaseCurrency { get; set; } 
    }
}


