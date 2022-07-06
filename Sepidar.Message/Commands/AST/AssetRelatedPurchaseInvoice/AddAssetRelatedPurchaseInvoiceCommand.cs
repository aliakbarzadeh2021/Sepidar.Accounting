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
    public class AddAssetRelatedPurchaseInvoiceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AssetRelatedPurchaseInvoiceId { get; set; }  
 
		public Nullable<Int32> AssetPurchaseInvoiceItemRef { get; set; }  
 
		public Nullable<Int32> AcquisitionReceiptItemRef { get; set; }  
 
		public Nullable<Int32> RepairItemRef { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Decimal PriceInBaseCurrency { get; set; }  
 
		public Nullable<Int32> PurchaseInvoiceItemRef { get; set; } 

        public void Validate()
        {
            new AddAssetRelatedPurchaseInvoiceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
