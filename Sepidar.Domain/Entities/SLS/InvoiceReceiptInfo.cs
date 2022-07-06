using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class InvoiceReceiptInfo : BaseEntity
    {
          
 
		public Int32 InvoiceReceiptInfoID { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public Decimal Discount { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Decimal PosAmount { get; set; }  
 
		public Decimal DraftAmount { get; set; }  
 
		public Nullable<Int32> PartyAccountSettlementItemRef { get; set; } 
    }
}


