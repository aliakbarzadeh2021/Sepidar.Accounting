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
    public class EditCommissionStepCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommissionStepId { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Decimal FromValue { get; set; }  
 
		public Decimal ToValue { get; set; }  
 
		public Decimal Amount { get; set; } 

        public void Validate()
        {
            new EditCommissionStepCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
