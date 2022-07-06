using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ColdDistributionInvoiceDto
    {
          
 
		public Int32 ColdDistributionInvoiceId { get; set; }  
 
		public Int32 ColdDistributionRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public Nullable<Int32> UnexecutedActReasonRef { get; set; } 
    }
}


