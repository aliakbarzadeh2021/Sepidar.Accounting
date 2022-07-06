using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommissionCalculationItem : BaseEntity
    {
          
 
		public Int32 CommissionCalculationItemID { get; set; }  
 
		public Int32 CommissionCalculationRef { get; set; }  
 
		public Nullable<Int32> ItemRef { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Decimal Amount { get; set; } 
    }
}


