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
    public class AddHotDistributionInventoryDeliveryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HotDistributionInventoryDeliveryId { get; set; }  
 
		public Int32 HotDistributionRef { get; set; }  
 
		public Int32 InventoryDeliveryRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; } 

        public void Validate()
        {
            new AddHotDistributionInventoryDeliveryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
