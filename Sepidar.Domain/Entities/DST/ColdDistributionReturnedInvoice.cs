using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ColdDistributionReturnedInvoice : BaseEntity
    {
          
 
		public Int32 ColdDistributionReturnedInvoiceId { get; set; }  
 
		public Int32 ColdDistributionRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Nullable<Int32> UnexecutedActReasonRef { get; set; } 
    }
}


