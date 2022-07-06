using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InvoiceReceiptInfoDto
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


