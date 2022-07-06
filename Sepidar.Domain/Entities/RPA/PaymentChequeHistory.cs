using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PaymentChequeHistory : BaseEntity
    {
          
 
		public Int32 PaymentChequeHistoryId { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> DurationType { get; set; }  
 
		public Nullable<Int32> PaymentChequeHistoryRef { get; set; }  
 
		public Int32 PaymentChequeRef { get; set; }  
 
		public Nullable<Int32> PaymentChequeBankingItemRef { get; set; }  
 
		public Nullable<Int32> RefundChequeItemRef { get; set; } 
    }
}


