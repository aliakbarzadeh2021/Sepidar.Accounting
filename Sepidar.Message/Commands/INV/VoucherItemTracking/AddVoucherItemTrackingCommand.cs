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
    public class AddVoucherItemTrackingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 VoucherItemTrackingID { get; set; }  
 
		public String Serial { get; set; }  
 
		public Nullable<Int32> InvoiceItemRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceItemRef { get; set; }  
 
		public Nullable<Int32> InventoryReceiptItemRef { get; set; }  
 
		public Nullable<Int32> InventoryDeliveryItemRef { get; set; } 

        public void Validate()
        {
            new AddVoucherItemTrackingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
