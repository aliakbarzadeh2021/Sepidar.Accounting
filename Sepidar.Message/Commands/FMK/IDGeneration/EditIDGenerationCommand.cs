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
    public class EditIDGenerationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String TableName { get; set; }  
 
		public Int32 LastId { get; set; } 

        public void Validate()
        {
            new EditIDGenerationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
