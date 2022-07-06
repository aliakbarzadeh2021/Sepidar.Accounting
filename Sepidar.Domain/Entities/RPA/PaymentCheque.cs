using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PaymentCheque : BaseEntity
    {
          
 
		public Int32 PaymentChequeId { get; set; }  
 
		public String Number { get; set; }  
 
		public String SecondNumber { get; set; }  
 
		public Boolean IsGuarantee { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<DateTime> Date { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 PaymentHeaderRef { get; set; }  
 
		public Int32 BankAccountRef { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public Int32 DurationType { get; set; }  
 
		public Int32 DlRef { get; set; }  
 
		public Int32 Type { get; set; } 
    }
}


