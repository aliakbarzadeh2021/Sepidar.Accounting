using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PartySettlementItemDto
    {
          
 
		public Int32 PartySettlementItemID { get; set; }  
 
		public Int32 PartySettlementRef { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> CommissionCalculationRef { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public Decimal RemainingAmount { get; set; } 
    }
}


