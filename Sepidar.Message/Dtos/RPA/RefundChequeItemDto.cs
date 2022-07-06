using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class RefundChequeItemDto
    {
          
 
		public Int32 RefundChequeItemID { get; set; }  
 
		public Nullable<Int32> ReceiptChequeRef { get; set; }  
 
		public Nullable<Int32> PaymentChequeRef { get; set; }  
 
		public Nullable<Int32> RefundChequeRef { get; set; }  
 
		public Nullable<DateTime> HeaderDate { get; set; }  
 
		public Nullable<Int32> HeaderNumber { get; set; }  
 
		public Nullable<Int32> State { get; set; } 
    }
}


