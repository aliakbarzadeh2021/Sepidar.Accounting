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
    public class EditDiscountItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DiscountItemID { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Decimal FromValue { get; set; }  
 
		public Decimal ToValue { get; set; }  
 
		public Nullable<Int32> DiscountType { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<Int32> ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Int32> ProductPackRef { get; set; } 

        public void Validate()
        {
            new EditDiscountItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
