using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ReceiptDraft : BaseEntity
    {
          
 
		public Int32 ReceiptDraftId { get; set; }  
 
		public String Number { get; set; }  
 
		public Nullable<DateTime> Date { get; set; }  
 
		public Nullable<Decimal> Amount { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 ReceiptHeaderRef { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; } 
    }
}


