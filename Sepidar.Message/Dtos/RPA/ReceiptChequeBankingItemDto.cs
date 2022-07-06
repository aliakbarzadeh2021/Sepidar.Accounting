using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ReceiptChequeBankingItemDto
    {
          
 
		public Int32 ReceiptChequeBankingItemId { get; set; }  
 
		public Int32 ReceiptChequeBankingRef { get; set; }  
 
		public Int32 ReceiptChequeRef { get; set; }  
 
		public Nullable<Int32> ReceiptChequeBankingItemRef { get; set; }  
 
		public Nullable<DateTime> ForcastDate { get; set; }  
 
		public Int32 State { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; }  
 
		public Nullable<Int32> CashRef { get; set; }  
 
		public Int32 HeaderState { get; set; } 
    }
}


