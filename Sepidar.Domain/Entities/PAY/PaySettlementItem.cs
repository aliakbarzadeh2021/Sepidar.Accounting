using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PaySettlementItem : BaseEntity
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


