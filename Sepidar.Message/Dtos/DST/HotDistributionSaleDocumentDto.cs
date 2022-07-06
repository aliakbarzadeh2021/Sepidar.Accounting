using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class HotDistributionSaleDocumentDto
    {
          
 
		public Int32 HotDistributionSaleDocumentId { get; set; }  
 
		public Int32 HotDistributionRef { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Boolean IsDocCreatedByHotDistribution { get; set; } 
    }
}


