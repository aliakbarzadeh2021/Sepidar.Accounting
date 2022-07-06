using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class DebtCollectionListInvoiceDto
    {
          
 
		public Int32 DebtCollectionListInvoiceId { get; set; }  
 
		public Int32 DebtCollectionListRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Decimal Discount { get; set; }  
 
		public Nullable<Int32> UnexecutedActReasonRef { get; set; }  
 
		public Nullable<Int32> PartyAccountSettlementRef { get; set; } 
    }
}


