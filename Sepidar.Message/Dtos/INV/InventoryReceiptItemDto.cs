using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InventoryReceiptItemDto
    {
          
 
		public Int32 InventoryReceiptItemID { get; set; }  
 
		public Int32 InventoryReceiptRef { get; set; }  
 
		public Boolean IsReturn { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Nullable<Int32> Base { get; set; }  
 
		public Nullable<Int32> ReturnBase { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public Decimal RemainingQuantity { get; set; }  
 
		public Nullable<Decimal> RemainingSecondaryQuantity { get; set; }  
 
		public Nullable<Int32> CurrencyRef { get; set; }  
 
		public Nullable<Decimal> CurrencyRate { get; set; }  
 
		public Nullable<Decimal> CurrencyValue { get; set; }  
 
		public Nullable<Decimal> Price { get; set; }  
 
		public Nullable<Decimal> Tax { get; set; }  
 
		public Nullable<Decimal> TaxCurrencyValue { get; set; }  
 
		public Nullable<Decimal> Duty { get; set; }  
 
		public Nullable<Decimal> DutyCurrencyValue { get; set; }  
 
		public Nullable<Decimal> TransportPrice { get; set; }  
 
		public Nullable<Decimal> TransportTax { get; set; }  
 
		public Nullable<Decimal> TransportDuty { get; set; }  
 
		public String TransportDescription { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> BasePurchaseInvoiceItemRef { get; set; }  
 
		public String ParityCheck { get; set; }  
 
		public Nullable<Int32> ProductOrderRef { get; set; }  
 
		public Nullable<Int32> InventoryDeliveryItemRef { get; set; }  
 
		public Nullable<Int32> WeighingRef { get; set; }  
 
		public Nullable<Decimal> ReturnedPrice { get; set; }  
 
		public Nullable<Decimal> Fee { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; }  
 
		public Nullable<Decimal> ReturnedFee { get; set; }  
 
		public Nullable<Decimal> ReturnedNetPrice { get; set; }  
 
		public Nullable<Int32> OtherCostsAmount { get; set; }  
 
		public Nullable<Int32> ServiceInventoryPurchaseInvoiceRef { get; set; }  
 
		public Nullable<Int32> ImportOrderFinalFee { get; set; }  
 
		public Nullable<Int32> BaseImportPurchaseInvoiceItemRef { get; set; } 
    }
}


