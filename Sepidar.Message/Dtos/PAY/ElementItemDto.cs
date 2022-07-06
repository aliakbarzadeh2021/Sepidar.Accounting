using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ElementItemDto
    {
          
 
		public Int32 ElementItemId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Int32 RelatedElementRef { get; set; }  
 
		public Nullable<Decimal> Coefficient { get; set; }  
 
		public Int32 Type { get; set; } 
    }
}


