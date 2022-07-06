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
    public class EditHotDistributionItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HotDistributionItemId { get; set; }  
 
		public Int32 HotDistributionRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; } 

        public void Validate()
        {
            new EditHotDistributionItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
