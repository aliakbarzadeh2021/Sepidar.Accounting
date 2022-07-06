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
    public class AddAdditionFactorItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AdditionFactorItemID { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal FromValue { get; set; }  
 
		public Decimal ToValue { get; set; }  
 
		public Int32 AdditionType { get; set; }  
 
		public Decimal Amount { get; set; } 

        public void Validate()
        {
            new AddAdditionFactorItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
