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
    public class AddInvoiceItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvoiceItemID { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public Int32 RowID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Int32> StockRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Decimal PriceInBaseCurrency { get; set; }  
 
		public Decimal Discount { get; set; }  
 
		public Decimal DiscountInBaseCurrency { get; set; }  
 
		public Decimal PriceInfoDiscountRate { get; set; }  
 
		public Decimal PriceInfoPriceDiscount { get; set; }  
 
		public Decimal PriceInfoPercentDiscount { get; set; }  
 
		public Decimal CustomerDiscount { get; set; }  
 
		public Decimal CustomerDiscountRate { get; set; }  
 
		public Decimal AggregateAmountDiscountRate { get; set; }  
 
		public Decimal AggregateAmountPriceDiscount { get; set; }  
 
		public Decimal AggregateAmountPercentDiscount { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> AdditionInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Tax { get; set; }  
 
		public Nullable<Decimal> TaxInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Duty { get; set; }  
 
		public Nullable<Decimal> DutyInBaseCurrency { get; set; }  
 
		public Decimal NetPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Rate { get; set; }  
 
		public Nullable<Int32> QuotationItemRef { get; set; }  
 
		public Nullable<Int32> OrderItemRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Nullable<Int32> DiscountInvoiceItemRef { get; set; }  
 
		public Nullable<Int32> ProductPackRef { get; set; }  
 
		public Nullable<Decimal> ProductPackQuantity { get; set; }  
 
		public Decimal AdditionFactor_VatEffective { get; set; }  
 
		public Decimal AdditionFactorInBaseCurrency_VatEffective { get; set; }  
 
		public Decimal AdditionFactor_VatIneffective { get; set; }  
 
		public Decimal AdditionFactorInBaseCurrency_VatIneffective { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; } 

        public void Validate()
        {
            new AddInvoiceItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
