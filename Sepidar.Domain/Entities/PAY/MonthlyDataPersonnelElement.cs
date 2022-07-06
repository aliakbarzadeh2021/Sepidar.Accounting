using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class MonthlyDataPersonnelElement : BaseEntity
    {
          
 
		public Int32 MonthlyDataPersonnelElementlId { get; set; }  
 
		public Int32 MonthlyDataPersonnelRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> ElementRef { get; set; }  
 
		public Nullable<Decimal> Value { get; set; } 
    }
}


