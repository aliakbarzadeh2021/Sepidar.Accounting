using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class StatusReceiptItemDto
    {
          
 
		public Int32 StatusReceiptItemID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 StatusRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; } 
    }
}


