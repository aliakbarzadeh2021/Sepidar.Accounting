using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ClosingOperation : BaseEntity
    {
          
 
		public Int32 ClosingOperationId { get; set; }  
 
		public Int32 ClosingGroup { get; set; }  
 
		public Nullable<Int32> ItemId { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 FiscalYearRef { get; set; } 
    }
}


