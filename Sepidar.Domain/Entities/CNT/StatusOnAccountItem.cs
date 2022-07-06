using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class StatusOnAccountItem : BaseEntity
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


