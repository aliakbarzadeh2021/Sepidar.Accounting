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
    public class EditTemplateEventCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TemplateEventID { get; set; }  
 
		public Int32 TemplateRef { get; set; }  
 
		public String EventKey { get; set; } 

        public void Validate()
        {
            new EditTemplateEventCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
