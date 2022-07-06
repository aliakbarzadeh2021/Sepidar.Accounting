using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PartyOpeningBalanceDto
    {
          
 
		public Int32 PartyOpeningBalanceID { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Decimal OpeningBalance { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 OpeningBalanceType { get; set; }  
 
		public Boolean FeedFromClosingOperation { get; set; } 
    }
}


