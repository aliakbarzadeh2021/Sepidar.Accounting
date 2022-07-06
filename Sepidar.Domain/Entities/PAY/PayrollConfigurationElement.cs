using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PayrollConfigurationElement : BaseEntity
    {
          
 
		public Int32 PayrollConfigurationElementId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Nullable<Decimal> Coefficient { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 PayrollConfigurationRef { get; set; } 
    }
}


