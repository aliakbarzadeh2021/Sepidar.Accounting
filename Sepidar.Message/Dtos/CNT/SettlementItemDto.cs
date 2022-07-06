using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class SettlementItemDto
    {
          
 
		public Int32 SettlementItemID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 StatusRef { get; set; }  
 
		public Int32 SettlementRef { get; set; }  
 
		public Decimal Remain { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 
    }
}


