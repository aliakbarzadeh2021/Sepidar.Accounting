using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PaymentChequeOtherDto
    {
          
 
		public Int32 PaymentChequeOtherId { get; set; }  
 
		public Int32 ReceiptChequeRef { get; set; }  
 
		public Int32 PaymentHeaderRef { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public DateTime HeaderDate { get; set; } 
    }
}


