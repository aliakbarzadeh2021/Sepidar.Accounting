using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ElementItem : BaseEntity
    {
          
 
		public Int32 ElementItemId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Int32 RelatedElementRef { get; set; }  
 
		public Nullable<Decimal> Coefficient { get; set; }  
 
		public Int32 Type { get; set; } 
    }
}


