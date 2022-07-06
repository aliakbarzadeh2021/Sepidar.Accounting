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
    public class AddTracingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TracingID { get; set; }  
 
		public Int32 TracingCategoryRef { get; set; }  
 
		public String Title { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddTracingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
