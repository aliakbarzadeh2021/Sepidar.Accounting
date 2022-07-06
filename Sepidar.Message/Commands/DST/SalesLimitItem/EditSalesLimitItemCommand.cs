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
    public class EditSalesLimitItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SalesLimitItemId { get; set; }  
 
		public Int32 SalesLimitRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; } 

        public void Validate()
        {
            new EditSalesLimitItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
