using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class POSSettlementItemDto
    {
          
 
		public Int32 SettlementItemID { get; set; }  
 
		public Int32 SettlementRef { get; set; }  
 
		public Int32 RowID { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Nullable<Int32> SalesInvoiceRef { get; set; }  
 
		public Nullable<Int32> SalesReturnedInvoiceRef { get; set; }  
 
		public String EntityFullName { get; set; } 
    }
}


