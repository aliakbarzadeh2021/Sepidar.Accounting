using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CommissionCalculationInvoiceDto
    {
          
 
		public Int32 CommissionCalculationInvoiceID { get; set; }  
 
		public Int32 CommissionCalculationRef { get; set; }  
 
		public Nullable<Int32> InvoiceItemRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceItemRef { get; set; } 
    }
}


