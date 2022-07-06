using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InventoryPurchaseInvoiceItemDto
    {
          
 
		public Int32 InventoryPurchaseInvoiceItemID { get; set; }  
 
		public Int32 InventoryPurchaseInvoiceRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public Decimal RemainingQuantity { get; set; }  
 
		public Nullable<Decimal> RemainingSecondaryQuantity { get; set; }  
 
		public Decimal CurrencyRate { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Nullable<Decimal> FeeInBaseCurrency { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Nullable<Decimal> PriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Nullable<Decimal> DiscountInBaseCurrentcy { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> AdditionInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Tax { get; set; }  
 
		public Nullable<Decimal> TaxInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Duty { get; set; }  
 
		public Nullable<Decimal> DutyInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TransportPrice { get; set; }  
 
		public Nullable<Decimal> TransportPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TransportTax { get; set; }  
 
		public Nullable<Decimal> TransportTaxInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TransportDuty { get; set; }  
 
		public Nullable<Decimal> TransportDutyInBaseCurrency { get; set; }  
 
		public String TransportDescription { get; set; }  
 
		public Nullable<Decimal> NetPriceInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> CostServiceAccountSLRef { get; set; }  
 
		public Nullable<Decimal> InsuranceAmount { get; set; }  
 
		public Nullable<Decimal> InsuranceAmountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> WithHoldingTaxAmount { get; set; }  
 
		public Nullable<Decimal> WithHoldingTaxAmountInBaseCurrency { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; } 
    }
}


