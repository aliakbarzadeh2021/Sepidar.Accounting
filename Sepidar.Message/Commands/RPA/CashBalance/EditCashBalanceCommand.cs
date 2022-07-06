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
    public class EditCashBalanceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CashBalanceId { get; set; }  
 
		public Decimal Balance { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 CashRef { get; set; } 

        public void Validate()
        {
            new EditCashBalanceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
