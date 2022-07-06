using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ReturnedInvoiceCommissionBroker : BaseEntity
    {
          
 
		public Int32 ReturnedInvoiceCommissionBrokerID { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Decimal SalePortionPercent { get; set; }  
 
		public Nullable<Decimal> ManualCommissionAmount { get; set; } 
    }
}


