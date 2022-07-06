using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ReturnedInvoiceItem : BaseEntity
    {
          
 
		public Int32 ReturnedInvoiceItemID { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
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
 
		public Decimal CustomerDiscount { get; set; }  
 
		public Decimal CustomerDiscountRate { get; set; }  
 
		public Decimal PriceInfoPriceDiscount { get; set; }  
 
		public Decimal PriceInfoPercentDiscount { get; set; }  
 
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
 
		public Nullable<Int32> InvoiceItemRef { get; set; }  
 
		public Nullable<Int32> ReturnOrderItemRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Nullable<Int32> DiscountReturnedInvoiceItemRef { get; set; }  
 
		public Nullable<Int32> ProductPackRef { get; set; }  
 
		public Nullable<Decimal> ProductPackQuantity { get; set; }  
 
		public Nullable<Int32> ReturnReasonRef { get; set; }  
 
		public Decimal AdditionFactor_VatEffective { get; set; }  
 
		public Decimal AdditionFactorInBaseCurrency_VatEffective { get; set; }  
 
		public Decimal AdditionFactor_VatIneffective { get; set; }  
 
		public Decimal AdditionFactorInBaseCurrency_VatIneffective { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; } 
    }
}


