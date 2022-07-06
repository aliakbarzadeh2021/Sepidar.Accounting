using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class VatItemDto
    {
          
 
		public Int32 VatItemID { get; set; }  
 
		public Int32 VatRef { get; set; }  
 
		public Int32 RowID { get; set; }  
 
		public Int32 VatItemType { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Nullable<Int32> InventoryReceiptRef { get; set; }  
 
		public Nullable<Int32> InventoryReceiptReturnRef { get; set; }  
 
		public Nullable<Int32> ServiceInventoryPurchaseInvoiceRef { get; set; }  
 
		public Nullable<Int32> AssetPurchaseInvoiceRef { get; set; }  
 
		public Nullable<Int32> AssetSaleRef { get; set; }  
 
		public Decimal TotalPriceInBaseCurrency { get; set; }  
 
		public Decimal TaxExemptItemPriceInBaseCurrency { get; set; }  
 
		public Decimal TaxExemptServicePriceInBaseCurrency { get; set; }  
 
		public Decimal NonTaxExemptItemPriceInBaseCurrency { get; set; }  
 
		public Decimal NonTaxExemptServicePriceInBaseCurrency { get; set; }  
 
		public Decimal NonTaxExemptItemTaxInBaseCurrency { get; set; }  
 
		public Decimal TaxExemptItemTaxInBaseCurrency { get; set; }  
 
		public Decimal NonTaxExemptItemDutyInBaseCurrency { get; set; }  
 
		public Decimal TaxExemptItemDutyInBaseCurrency { get; set; }  
 
		public Decimal NonTaxExemptServiceTaxInBaseCurrency { get; set; }  
 
		public Decimal TaxExemptServiceTaxInBaseCurrency { get; set; }  
 
		public Decimal NonTaxExemptServiceDutyInBaseCurrency { get; set; }  
 
		public Decimal TaxExemptServiceDutyInBaseCurrency { get; set; }  
 
		public Int32 DomesticType { get; set; }  
 
		public String EntityFullName { get; set; }  
 
		public Nullable<Int32> StatusRef { get; set; }  
 
		public Nullable<Int32> CustomsClearanceRef { get; set; }  
 
		public Nullable<Int32> BillOfLoadingRef { get; set; }  
 
		public Nullable<Int32> InsurancePolicyRef { get; set; } 
    }
}


