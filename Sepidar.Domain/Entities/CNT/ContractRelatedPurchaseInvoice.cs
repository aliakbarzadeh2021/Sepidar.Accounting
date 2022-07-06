using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ContractRelatedPurchaseInvoice : BaseEntity
    {
          
 
		public Int32 ContractRelatedPurchaseInvoiceId { get; set; }  
 
		public Int32 PurchaseInvoiceRef { get; set; }  
 
		public Int32 TenderRef { get; set; } 
    }
}


