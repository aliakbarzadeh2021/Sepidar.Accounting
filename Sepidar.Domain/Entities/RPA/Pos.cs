using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Pos : BaseEntity
    {
          
 
		public Int32 PosId { get; set; }  
 
		public Int32 BankAccountRef { get; set; }  
 
		public String TerminalNo { get; set; }  
 
		public Int32 DlRef { get; set; }  
 
		public Decimal FirstAmount { get; set; }  
 
		public Nullable<Decimal> Rate { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public Decimal Balance { get; set; } 
    }
}


