using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ReturnedInvoiceBroker : BaseEntity
    {
          
 
		public Int32 ReturnedInvoiceBrokerID { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Decimal Commission { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal CommissionInBaseCurrency { get; set; }  
 
		public Int32 PartyRef { get; set; } 
    }
}


