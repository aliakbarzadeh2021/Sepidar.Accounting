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
    public class EditTopicCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TopicId { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Topic1 { get; set; }  
 
		public String Topic_En { get; set; }  
 
		public String Category { get; set; }  
 
		public String Category_En { get; set; } 

        public void Validate()
        {
            new EditTopicCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
