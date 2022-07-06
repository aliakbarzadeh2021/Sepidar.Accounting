using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PosBalanceDto
    {
          
 
		public Int32 PosBalanceId { get; set; }  
 
		public Decimal Balance { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 PosRef { get; set; } 
    }
}


