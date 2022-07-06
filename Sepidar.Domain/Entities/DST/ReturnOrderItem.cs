using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ReturnOrderItem : BaseEntity
    {
          
 
		public Int32 ReturnOrderItemID { get; set; }  
 
		public Int32 ReturnOrderRef { get; set; }  
 
		public Int32 RowID { get; set; }  
 
		public Nullable<Int32> InvoiceItemRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Int32> StockRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public Nullable<Decimal> Fee { get; set; }  
 
		public Nullable<Decimal> Price { get; set; }  
 
		public Nullable<Decimal> PriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Nullable<Decimal> DiscountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> PriceInfoDiscountRate { get; set; }  
 
		public Nullable<Decimal> PriceInfoPriceDiscount { get; set; }  
 
		public Nullable<Decimal> PriceInfoPercentDiscount { get; set; }  
 
		public Nullable<Decimal> CustomerDiscount { get; set; }  
 
		public Nullable<Decimal> CustomerDiscountRate { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> AdditionInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Tax { get; set; }  
 
		public Nullable<Decimal> TaxInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Duty { get; set; }  
 
		public Nullable<Decimal> DutyInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> NetPriceInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Nullable<Int32> DiscountReturnOrderItemRef { get; set; }  
 
		public Nullable<Decimal> Rate { get; set; }  
 
		public Nullable<Int32> ReurnReasonRef { get; set; }  
 
		public Nullable<Int32> ProductPackRef { get; set; }  
 
		public Nullable<Decimal> ProductPackQuantity { get; set; }  
 
		public Nullable<Decimal> AggregateAmountDiscountRate { get; set; }  
 
		public Nullable<Decimal> AggregateAmountPriceDiscount { get; set; }  
 
		public Nullable<Decimal> AggregateAmountPercentDiscount { get; set; }  
 
		public Nullable<Int32> ReturnReasonRef { get; set; }  
 
		public Decimal AdditionFactor_VatEffective { get; set; }  
 
		public Decimal AdditionFactorInBaseCurrency_VatEffective { get; set; }  
 
		public Decimal AdditionFactor_VatIneffective { get; set; }  
 
		public Decimal AdditionFactorInBaseCurrency_VatIneffective { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; } 
    }
}


