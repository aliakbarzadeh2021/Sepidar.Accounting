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
    public class EditPaymentChequeBankingItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PaymentChequeBankingItemId { get; set; }  
 
		public Int32 PaymentChequeBankingRef { get; set; }  
 
		public Int32 PaymentChequeRef { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; } 

        public void Validate()
        {
            new EditPaymentChequeBankingItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
