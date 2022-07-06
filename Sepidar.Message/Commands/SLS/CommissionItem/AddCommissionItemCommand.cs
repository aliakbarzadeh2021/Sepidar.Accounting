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
    public class AddCommissionItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommissionItemId { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Int32 ItemRef { get; set; } 

        public void Validate()
        {
            new AddCommissionItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
