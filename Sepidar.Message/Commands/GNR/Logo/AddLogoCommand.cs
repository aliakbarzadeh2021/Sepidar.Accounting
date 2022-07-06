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
    public class AddLogoCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Byte[] Logo1 { get; set; } 

        public void Validate()
        {
            new AddLogoCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
