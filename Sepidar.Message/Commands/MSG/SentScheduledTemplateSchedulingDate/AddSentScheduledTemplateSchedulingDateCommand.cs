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
    public class AddSentScheduledTemplateSchedulingDateCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SentScheduledTemplateSchedulingDateID { get; set; }  
 
		public Int32 TemplateSchedulingRef { get; set; }  
 
		public Int32 SchedulingItemRef { get; set; } 

        public void Validate()
        {
            new AddSentScheduledTemplateSchedulingDateCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
