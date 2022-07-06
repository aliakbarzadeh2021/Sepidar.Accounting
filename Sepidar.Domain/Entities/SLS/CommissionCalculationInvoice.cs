using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommissionCalculationInvoice : BaseEntity
    {
          
 
		public Int32 CommissionCalculationInvoiceID { get; set; }  
 
		public Int32 CommissionCalculationRef { get; set; }  
 
		public Nullable<Int32> InvoiceItemRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceItemRef { get; set; } 
    }
}


