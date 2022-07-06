using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ReceiptChequeHistory : BaseEntity
    {
          
 
		public Int32 ReceiptChequeHistoryId { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> ReceiptChequeHistoryRef { get; set; }  
 
		public Int32 ReceiptChequeRef { get; set; }  
 
		public Nullable<Int32> ReceiptChequeBankingItemRef { get; set; }  
 
		public Nullable<Int32> PaymentChequeOtherRef { get; set; }  
 
		public Nullable<Int32> RefundChequeItemRef { get; set; } 
    }
}


