using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class BankAccountBalanceDto
    {
          
 
		public Int32 BankAccountBalanceId { get; set; }  
 
		public Decimal Balance { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 BankAccountRef { get; set; } 
    }
}


