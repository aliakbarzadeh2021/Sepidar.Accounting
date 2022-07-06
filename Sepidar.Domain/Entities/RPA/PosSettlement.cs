using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PosSettlement : BaseEntity
    {
          
 
		public Int32 PosSettlementID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public DateTime SettleReceiptsTo { get; set; }  
 
		public Int32 PosRef { get; set; }  
 
		public Nullable<Int32> SettlementReceiptRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; } 
    }
}


