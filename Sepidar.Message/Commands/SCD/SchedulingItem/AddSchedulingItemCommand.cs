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
    public class AddSchedulingItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SchedulingItemId { get; set; }  
 
		public Int32 SchedulingRef { get; set; }  
 
		public DateTime DateTime { get; set; } 

        public void Validate()
        {
            new AddSchedulingItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
