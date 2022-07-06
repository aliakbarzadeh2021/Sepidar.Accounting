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
    public class AddPurchaseInvoiceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PurchaseInvoiceID { get; set; }  
 
		public Int32 VendorDLRef { get; set; }  
 
		public Int32 PurchaseOrderRef { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public String PurchaseNumber { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal CurrencyRate { get; set; }  
 
		public String Description { get; set; }  
 
		public Nullable<Decimal> Price { get; set; }  
 
		public Nullable<Decimal> PriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Nullable<Decimal> DiscountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> AdditionInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; }  
 
		public Nullable<Decimal> NetPriceInBaseCurrency { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Boolean CanTransferNextPeriod { get; set; }  
 
		public Nullable<Int32> BasePurchaseInvoiceRef { get; set; }  
 
		public Boolean IsInitial { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddPurchaseInvoiceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
