using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class SettlementDebtItem : BaseEntity
    {
          
 
		public Int32 SettlementDebtItemID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 CostStatementItemRef { get; set; }  
 
		public Int32 SettlementRef { get; set; }  
 
		public Decimal Remain { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 
    }
}


