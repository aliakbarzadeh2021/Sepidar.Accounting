using Sepidar.Message.Base;
using Sepidar.Message.Extentions;
using Sepidar.Message.Validators;
using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class AddPaymentChequeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
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

        public void Validate()
        {
            new AddPaymentChequeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
