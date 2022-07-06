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
    public class AddPaymentChequeBankingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PaymentChequeBankingId { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; } 

        public void Validate()
        {
            new AddPaymentChequeBankingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
