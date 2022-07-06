using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PartySettlementItem : BaseEntity
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


