using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommissionStep : BaseEntity
    {
          
 
		public Int32 CommissionStepId { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Decimal FromValue { get; set; }  
 
		public Decimal ToValue { get; set; }  
 
		public Decimal Amount { get; set; } 
    }
}


