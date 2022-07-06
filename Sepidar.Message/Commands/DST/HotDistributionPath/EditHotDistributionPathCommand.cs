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
    public class EditHotDistributionPathCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HotDistributionPathId { get; set; }  
 
		public Int32 HotDistributionRef { get; set; }  
 
		public Int32 PathRef { get; set; } 

        public void Validate()
        {
            new EditHotDistributionPathCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
