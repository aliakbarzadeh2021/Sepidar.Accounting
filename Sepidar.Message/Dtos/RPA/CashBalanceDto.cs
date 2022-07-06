using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CashBalanceDto
    {
          
 
		public Int32 CashBalanceId { get; set; }  
 
		public Decimal Balance { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 CashRef { get; set; } 
    }
}


