using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class MonthlyDataPersonnelElementDto
    {
          
 
		public Int32 MonthlyDataPersonnelElementlId { get; set; }  
 
		public Int32 MonthlyDataPersonnelRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> ElementRef { get; set; }  
 
		public Nullable<Decimal> Value { get; set; } 
    }
}


