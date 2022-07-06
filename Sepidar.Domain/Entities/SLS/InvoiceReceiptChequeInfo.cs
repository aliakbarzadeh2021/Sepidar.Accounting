using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class InvoiceReceiptChequeInfo : BaseEntity
    {
          
 
		public Int32 InvoiceReceiptChequeInfoId { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public String Number { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String AccountNo { get; set; }  
 
		public Int32 BankRef { get; set; }  
 
		public Nullable<Int32> PartyAccountSettlementItemRef { get; set; } 
    }
}


