using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PosSettlementDto
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


