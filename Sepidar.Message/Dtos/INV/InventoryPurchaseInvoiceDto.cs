using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class InventoryPurchaseInvoiceDto
    {
          
 
		public Int32 InventoryPurchaseInvoiceID { get; set; }  
 
		public Int32 VendorDLRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Nullable<Int32> InvoiceNumber { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal CurrencyRate { get; set; }  
 
		public Nullable<Decimal> TotalPrice { get; set; }  
 
		public Nullable<Decimal> TotalPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalTax { get; set; }  
 
		public Nullable<Decimal> TotalDuty { get; set; }  
 
		public Nullable<Decimal> TotalTransportPrice { get; set; }  
 
		public Nullable<Decimal> TotalNetPrice { get; set; }  
 
		public Nullable<Decimal> TotalNetPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalWithHoldingTaxAmount { get; set; }  
 
		public Nullable<Decimal> TotalInsuranceAmount { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> AccountingVoucherRef { get; set; }  
 
		public Nullable<Int32> SLAccountRef { get; set; }  
 
		public Nullable<Int32> CostCenterRef { get; set; }  
 
		public Nullable<Int32> AssetAcquisitionPurchaseSLRef { get; set; } 
    }
}


