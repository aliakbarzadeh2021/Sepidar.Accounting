using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PartyOpeningBalance : BaseEntity
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


