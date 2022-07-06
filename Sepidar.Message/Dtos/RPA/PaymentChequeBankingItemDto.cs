using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PaymentChequeBankingItemDto
    {
          
 
		public Int32 PaymentChequeBankingItemId { get; set; }  
 
		public Int32 PaymentChequeBankingRef { get; set; }  
 
		public Int32 PaymentChequeRef { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; } 
    }
}


