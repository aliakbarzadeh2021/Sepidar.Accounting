using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CommissionStepDto
    {
          
 
		public Int32 CommissionStepId { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Decimal FromValue { get; set; }  
 
		public Decimal ToValue { get; set; }  
 
		public Decimal Amount { get; set; } 
    }
}


