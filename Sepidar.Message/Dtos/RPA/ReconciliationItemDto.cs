using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ReconciliationItemDto
    {
          
 
		public Int32 ReconciliationItemId { get; set; }  
 
		public Nullable<Int32> ReceiptDraftRef { get; set; }  
 
		public Nullable<Int32> PaymentDraftRef { get; set; }  
 
		public Nullable<Int32> ReceiptChequeBankingItemRef { get; set; }  
 
		public Nullable<Int32> PaymentChequeBankingItemRef { get; set; }  
 
		public Nullable<Int32> PaymentChequeRef { get; set; }  
 
		public Nullable<Int32> RefundChequeItemRef { get; set; }  
 
		public Nullable<Int32> RelationNo { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Decimal Debit { get; set; }  
 
		public Decimal Credit { get; set; }  
 
		public Int32 ReconciliationRef { get; set; }  
 
		public Nullable<Int32> ReconciliationItemRef { get; set; } 
    }
}


