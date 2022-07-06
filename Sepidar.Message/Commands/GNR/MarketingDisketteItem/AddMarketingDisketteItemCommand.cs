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
    public class AddMarketingDisketteItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MarketingDisketteItemID { get; set; }  
 
		public Int32 MarketingDisketteRef { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Nullable<Int32> InventoryReceiptRef { get; set; }  
 
		public Nullable<Int32> ReturnedInventoryReceiptRef { get; set; }  
 
		public Nullable<Int32> ServiceInventoryPurchaseInvoiceRef { get; set; }  
 
		public Nullable<Int32> StatusRef { get; set; }  
 
		public Boolean UsedInDiskette { get; set; }  
 
		public String EntityFullName { get; set; }  
 
		public Nullable<Boolean> ISDealTypeLowerThanTenPercent { get; set; }  
 
		public Nullable<Boolean> IsRefusal { get; set; }  
 
		public Nullable<Boolean> IsTransport { get; set; } 

        public void Validate()
        {
            new AddMarketingDisketteItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
