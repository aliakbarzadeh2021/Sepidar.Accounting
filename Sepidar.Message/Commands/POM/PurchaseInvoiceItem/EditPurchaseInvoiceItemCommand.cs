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
    public class EditPurchaseInvoiceItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PurchaseInvoiceItemID { get; set; }  
 
		public Int32 PurchaseInvoiceRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Int32 PurchaseOrderItemRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Nullable<Decimal> FeeInBaseCurrency { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Nullable<Decimal> PriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Nullable<Decimal> DiscountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> AdditionInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; }  
 
		public Nullable<Decimal> NetPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> BaseInvoiceCalculatedPriceNoteInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditPurchaseInvoiceItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
