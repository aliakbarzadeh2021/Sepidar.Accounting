using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ShredItem : BaseEntity
    {
          
 
		public Int32 ShredItemID { get; set; }  
 
		public Int32 ShredRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public DateTime UsanceDate { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<Decimal> InterestAmount { get; set; }  
 
		public Nullable<Decimal> PenaltyAmount { get; set; }  
 
		public Nullable<Decimal> PenaltyRate { get; set; }  
 
		public Int32 Status { get; set; }  
 
		public Nullable<Int32> PaymentRef { get; set; }  
 
		public Nullable<Int32> ReceiptRef { get; set; }  
 
		public Nullable<Int32> PartySettlementRef { get; set; }  
 
		public Nullable<DateTime> PaymentDate { get; set; }  
 
		public Boolean IsPaid { get; set; }  
 
		public Nullable<DateTime> PaidDate { get; set; }  
 
		public String PaidDesc { get; set; } 
    }
}


