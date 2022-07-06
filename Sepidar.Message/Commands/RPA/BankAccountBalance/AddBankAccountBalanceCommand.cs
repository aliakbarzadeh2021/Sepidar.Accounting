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
    public class AddBankAccountBalanceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BankAccountBalanceId { get; set; }  
 
		public Decimal Balance { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 BankAccountRef { get; set; } 

        public void Validate()
        {
            new AddBankAccountBalanceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
