using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class BankAccount : BaseEntity
    {
          
 
		public Int32 BankAccountId { get; set; }  
 
		public Int32 BankBranchRef { get; set; }  
 
		public String AccountNo { get; set; }  
 
		public Int32 AccountTypeRef { get; set; }  
 
		public Int32 DlRef { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal FirstAmount { get; set; }  
 
		public DateTime FirstDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public Decimal Balance { get; set; }  
 
		public Nullable<Decimal> BillFirstAmount { get; set; }  
 
		public Nullable<Decimal> BlockedAmount { get; set; }  
 
		public String ClearFormatName { get; set; }  
 
		public String Owner { get; set; }  
 
		public String Owner_En { get; set; } 
    }
}


