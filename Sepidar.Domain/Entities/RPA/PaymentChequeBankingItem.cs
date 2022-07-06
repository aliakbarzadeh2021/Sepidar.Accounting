using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PaymentChequeBankingItem : BaseEntity
    {
          
 
		public Int32 PaymentChequeBankingItemId { get; set; }  
 
		public Int32 PaymentChequeBankingRef { get; set; }  
 
		public Int32 PaymentChequeRef { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; } 
    }
}


