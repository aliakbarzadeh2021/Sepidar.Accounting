using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class POSReturnedInvoiceItemDto
    {
          
 
		public Int32 ReturnedInvoiceItemID { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Int32 RowID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Decimal SecondaryQuantity { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> Tax { get; set; }  
 
		public Nullable<Decimal> Duty { get; set; }  
 
		public Decimal NetPrice { get; set; } 
    }
}


