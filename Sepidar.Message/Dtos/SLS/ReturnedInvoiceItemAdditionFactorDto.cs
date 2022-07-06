using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ReturnedInvoiceItemAdditionFactorDto
    {
          
 
		public Int32 ReturnedInvoiceItemAdditionFactorID { get; set; }  
 
		public Int32 ReturnedInvoiceItemRef { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal Value { get; set; }  
 
		public Decimal ValueInBaseCurrency { get; set; } 
    }
}


