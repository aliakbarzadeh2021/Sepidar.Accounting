using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CommissionCalculationItemDto
    {
          
 
		public Int32 CommissionCalculationItemID { get; set; }  
 
		public Int32 CommissionCalculationRef { get; set; }  
 
		public Nullable<Int32> ItemRef { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Decimal Amount { get; set; } 
    }
}


