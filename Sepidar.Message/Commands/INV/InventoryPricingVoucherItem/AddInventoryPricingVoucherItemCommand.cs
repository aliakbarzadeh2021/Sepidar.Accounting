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
    public class AddInventoryPricingVoucherItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InventoryPricingVoucherItemID { get; set; }  
 
		public Int32 InventoryPricingVoucherRef { get; set; }  
 
		public Int32 InventoryVoucherItemRef { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddInventoryPricingVoucherItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
