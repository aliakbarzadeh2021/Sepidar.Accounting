using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ReturnedInvoiceCommissionBrokerDto
    {
          
 
		public Int32 ReturnedInvoiceCommissionBrokerID { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Decimal SalePortionPercent { get; set; }  
 
		public Nullable<Decimal> ManualCommissionAmount { get; set; } 
    }
}


