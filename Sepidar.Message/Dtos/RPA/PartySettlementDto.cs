using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PartySettlementDto
    {
          
 
		public Int32 PartySettlementID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal SettlementByRemainingAmount { get; set; }  
 
		public Decimal SettlementByRemainingAmountInBaseCurrency { get; set; }  
 
		public Decimal SettlementByRemainingRate { get; set; }  
 
		public Nullable<Int32> ReceiptHeaderRef { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Int32 SettlementType { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public String CreatorForm { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


