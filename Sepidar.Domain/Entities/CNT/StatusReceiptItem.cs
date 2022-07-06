using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class StatusReceiptItem : BaseEntity
    {
          
 
		public Int32 StatusReceiptItemID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 StatusRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; } 
    }
}


