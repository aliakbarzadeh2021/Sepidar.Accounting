using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ReturnedInvoiceBrokerDto
    {
          
 
		public Int32 ReturnedInvoiceBrokerID { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Decimal Commission { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal CommissionInBaseCurrency { get; set; }  
 
		public Int32 PartyRef { get; set; } 
    }
}


