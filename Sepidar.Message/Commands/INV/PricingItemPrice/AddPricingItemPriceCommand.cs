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
    public class AddPricingItemPriceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PricingItemPriceID { get; set; }  
 
		public Int32 InventoryPricingRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Decimal TotalPrice { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddPricingItemPriceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
