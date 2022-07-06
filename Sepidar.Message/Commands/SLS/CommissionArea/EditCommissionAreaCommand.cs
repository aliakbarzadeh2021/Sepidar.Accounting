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
    public class EditCommissionAreaCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommissionAreaId { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Int32 AreaRef { get; set; } 

        public void Validate()
        {
            new EditCommissionAreaCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
