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
    public class AddClosingOperationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ClosingOperationId { get; set; }  
 
		public Int32 ClosingGroup { get; set; }  
 
		public Nullable<Int32> ItemId { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 FiscalYearRef { get; set; } 

        public void Validate()
        {
            new AddClosingOperationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
