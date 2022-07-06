using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InvoiceCommissionBrokerDto
    {
          
 
		public Int32 InvoiceCommissionBrokerID { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Decimal SalePortionPercent { get; set; }  
 
		public Nullable<Decimal> ManualCommissionAmount { get; set; } 
    }
}


