using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class HotDistributionSaleDocument : BaseEntity
    {
          
 
		public Int32 HotDistributionSaleDocumentId { get; set; }  
 
		public Int32 HotDistributionRef { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Boolean IsDocCreatedByHotDistribution { get; set; } 
    }
}


