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
    public class EditContractElementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ContractElementId { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Decimal Value { get; set; } 

        public void Validate()
        {
            new EditContractElementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
