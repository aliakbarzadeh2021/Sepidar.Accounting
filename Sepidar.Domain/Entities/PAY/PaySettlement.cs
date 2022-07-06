using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PaySettlement : BaseEntity
    {
          
 
		public Int32 SettlementID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Nullable<Int32> AccountingVoucherRef { get; set; }  
 
		public Nullable<Decimal> NetPay { get; set; }  
 
		public Nullable<Decimal> NewYearBonusNet { get; set; }  
 
		public Nullable<Decimal> LeaveRepayment { get; set; }  
 
		public Nullable<Decimal> WorkingHistoryRepayment { get; set; }  
 
		public Nullable<Decimal> NotsettledShredAmount { get; set; }  
 
		public Nullable<Decimal> Total { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


