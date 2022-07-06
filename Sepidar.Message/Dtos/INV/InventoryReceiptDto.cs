using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InventoryReceiptDto
    {
          
 
		public Int32 InventoryReceiptID { get; set; }  
 
		public Boolean IsReturn { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 PurchaseType { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Nullable<Int32> DelivererDLRef { get; set; }  
 
		public Nullable<Int32> SLAccountRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> AccountingVoucherRef { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Nullable<Int32> TransportBrokerSLAccountRef { get; set; }  
 
		public Nullable<Int32> TransporterDLRef { get; set; }  
 
		public Nullable<Decimal> TotalPrice { get; set; }  
 
		public Nullable<Decimal> TotalTax { get; set; }  
 
		public Nullable<Decimal> TotalDuty { get; set; }  
 
		public Nullable<Decimal> TotalTransportPrice { get; set; }  
 
		public Nullable<Decimal> TotalNetPrice { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 CreatorForm { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> BasePurchaseInvoiceRef { get; set; }  
 
		public Nullable<Int32> BaseInventoryDeliveryRef { get; set; }  
 
		public Nullable<Decimal> TotalReturnedPrice { get; set; }  
 
		public Nullable<Decimal> TotalReturnedNetPrice { get; set; }  
 
		public Nullable<Int32> BaseImportPurchaseInvoiceRef { get; set; } 
    }
}


