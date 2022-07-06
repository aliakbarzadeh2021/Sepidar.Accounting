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
    public class AddItemDiscountCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ItemDiscountID { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; } 

        public void Validate()
        {
            new AddItemDiscountCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
