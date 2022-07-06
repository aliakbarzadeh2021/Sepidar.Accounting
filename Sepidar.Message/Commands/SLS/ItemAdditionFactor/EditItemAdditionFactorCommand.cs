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
    public class EditItemAdditionFactorCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ItemAdditionFactorID { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; } 

        public void Validate()
        {
            new EditItemAdditionFactorCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
