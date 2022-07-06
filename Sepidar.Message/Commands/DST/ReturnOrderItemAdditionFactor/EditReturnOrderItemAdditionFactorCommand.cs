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
    public class EditReturnOrderItemAdditionFactorCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReturnOrderItemAdditionFactorID { get; set; }  
 
		public Int32 ReturnOrderItemRef { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal Value { get; set; }  
 
		public Decimal ValueInBaseCurrency { get; set; } 

        public void Validate()
        {
            new EditReturnOrderItemAdditionFactorCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
