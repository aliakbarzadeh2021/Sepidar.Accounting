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
    public class EditTemplateSchedulingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TemplateSchedulingID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public Int32 SchedulingRef { get; set; } 

        public void Validate()
        {
            new EditTemplateSchedulingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
