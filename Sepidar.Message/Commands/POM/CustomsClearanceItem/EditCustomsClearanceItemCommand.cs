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
    public class EditCustomsClearanceItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CustomsClearanceItemID { get; set; }  
 
		public Int32 CustomsClearanceRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 PurchaseInvoiceItemRef { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Currencyrate { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public Decimal PurchaseInvoiceItemNetPrice { get; set; }  
 
		public Decimal PurchaseInvoiceItemNetPriceInBaseCurrency { get; set; }  
 
		public Decimal CustomsCost { get; set; }  
 
		public Decimal Tax { get; set; }  
 
		public Decimal Duty { get; set; } 

        public void Validate()
        {
            new EditCustomsClearanceItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
