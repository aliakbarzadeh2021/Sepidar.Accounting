using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ColdDistributionReturnedInvoiceDto
    {
          
 
		public Int32 ColdDistributionReturnedInvoiceId { get; set; }  
 
		public Int32 ColdDistributionRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Nullable<Int32> UnexecutedActReasonRef { get; set; } 
    }
}


