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
    public class AddIDGenerationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String TableName { get; set; }  
 
		public Int32 LastId { get; set; } 

        public void Validate()
        {
            new AddIDGenerationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
