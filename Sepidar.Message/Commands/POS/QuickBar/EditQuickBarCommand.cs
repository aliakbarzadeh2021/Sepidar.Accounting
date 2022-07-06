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
    public class EditQuickBarCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QuickBarID { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditQuickBarCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
