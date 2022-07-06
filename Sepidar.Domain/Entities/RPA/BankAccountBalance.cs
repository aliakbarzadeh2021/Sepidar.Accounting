using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class BankAccountBalance : BaseEntity
    {
          
 
		public Int32 BankAccountBalanceId { get; set; }  
 
		public Decimal Balance { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 BankAccountRef { get; set; } 
    }
}


