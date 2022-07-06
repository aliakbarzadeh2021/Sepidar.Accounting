using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PosDto
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


