using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ClosingOperationDto
    {
          
 
		public Int32 ClosingOperationId { get; set; }  
 
		public Int32 ClosingGroup { get; set; }  
 
		public Nullable<Int32> ItemId { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 FiscalYearRef { get; set; } 
    }
}


