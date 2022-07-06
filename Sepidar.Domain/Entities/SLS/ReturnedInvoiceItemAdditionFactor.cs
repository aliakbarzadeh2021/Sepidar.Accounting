using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ReturnedInvoiceItemAdditionFactor : BaseEntity
    {
          
 
		public Int32 ReturnedInvoiceItemAdditionFactorID { get; set; }  
 
		public Int32 ReturnedInvoiceItemRef { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal Value { get; set; }  
 
		public Decimal ValueInBaseCurrency { get; set; } 
    }
}


