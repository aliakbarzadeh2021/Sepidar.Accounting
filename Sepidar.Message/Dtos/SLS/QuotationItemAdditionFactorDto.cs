using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class QuotationItemAdditionFactorDto
    {
          
 
		public Int32 QuotationItemAdditionFactorID { get; set; }  
 
		public Int32 QuotationItemRef { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal Value { get; set; }  
 
		public Decimal ValueInBaseCurrency { get; set; } 
    }
}


