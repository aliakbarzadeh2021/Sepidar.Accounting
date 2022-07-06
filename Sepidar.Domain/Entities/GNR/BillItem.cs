using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class BillItem : BaseEntity
    {
          
 
		public Int32 BillItemID { get; set; }  
 
		public Int32 BillRef { get; set; }  
 
		public Int32 RowID { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Nullable<Int32> DebitCreditNoteRef { get; set; }  
 
		public Nullable<Int32> InventoryReceiptRef { get; set; }  
 
		public Nullable<Int32> ServiceInventoryPurchaseInvoiceRef { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Nullable<Int32> ReceiptHeaderRef { get; set; }  
 
		public Nullable<Int32> RefundChequeRef { get; set; }  
 
		public Nullable<Int32> ShredRef { get; set; }  
 
		public Nullable<Decimal> AmountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Amount { get; set; }  
 
		public String EntityFullName { get; set; }  
 
		public Nullable<Int32> PurchaseInvoiceRef { get; set; }  
 
		public Nullable<Int32> BillOfLoadingRef { get; set; }  
 
		public Nullable<Int32> InsurancePolicyRef { get; set; }  
 
		public Nullable<Int32> CommercialOrderRef { get; set; }  
 
		public Nullable<Int32> CustomsClearanceRef { get; set; } 
    }
}


