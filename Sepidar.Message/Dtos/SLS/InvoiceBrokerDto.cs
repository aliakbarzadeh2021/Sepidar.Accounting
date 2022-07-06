using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InvoiceBrokerDto
    {
          
 
		public Int32 BrokerID { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Decimal Commission { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal CommissionInBaseCurrency { get; set; } 
    }
}


