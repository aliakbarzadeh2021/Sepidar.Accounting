using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class StatusOnAccountItemDto
    {
          
 
		public Int32 StatusOnAccountItemID { get; set; }  
 
		public Int32 StatusRef { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; }  
 
		public Nullable<Int32> PaymentRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 
    }
}


