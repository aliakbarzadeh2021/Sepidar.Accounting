using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class BillOfLoadingItemDto
    {
          
 
		public Int32 BillOfLoadingItemID { get; set; }  
 
		public Int32 BillOfLoadingRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 BasePurchaseInvoiceItemRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public Nullable<Decimal> TotalWeight { get; set; }  
 
		public Nullable<Decimal> ItemWeight { get; set; }  
 
		public Decimal ItemNetPrice { get; set; }  
 
		public Nullable<Decimal> ItemNetPriceInBaseCurrency { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Nullable<Decimal> PriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Nullable<Decimal> DiscountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> AdditionInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; }  
 
		public Nullable<Decimal> NetPriceInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


