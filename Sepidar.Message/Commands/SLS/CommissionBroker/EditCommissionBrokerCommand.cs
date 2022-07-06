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
    public class EditCommissionBrokerCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommissionBrokerId { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Int32 PartyRef { get; set; } 

        public void Validate()
        {
            new EditCommissionBrokerCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
