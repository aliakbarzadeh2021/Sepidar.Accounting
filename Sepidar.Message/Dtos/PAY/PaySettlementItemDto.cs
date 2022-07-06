using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PaySettlementItemDto
    {
          
 
		public Int32 SettlementItemID { get; set; }  
 
		public Int32 SettlementRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Int32 AccoungSLRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


