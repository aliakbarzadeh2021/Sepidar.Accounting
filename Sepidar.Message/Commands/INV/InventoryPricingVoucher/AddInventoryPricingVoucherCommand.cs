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
    public class AddInventoryPricingVoucherCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InventoryPricingVoucherID { get; set; }  
 
		public Int32 InventoryPricingRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 InventoryVoucherType { get; set; }  
 
		public Int32 InventoryVoucherRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddInventoryPricingVoucherCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
