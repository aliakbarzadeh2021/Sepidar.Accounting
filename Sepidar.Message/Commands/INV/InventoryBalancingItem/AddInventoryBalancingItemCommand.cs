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
    public class AddInventoryBalancingItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InventoryBalancingItemId { get; set; }  
 
		public Int32 InventoryBalancingRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Int32> TagNumber { get; set; }  
 
		public Nullable<Decimal> Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; } 

        public void Validate()
        {
            new AddInventoryBalancingItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
