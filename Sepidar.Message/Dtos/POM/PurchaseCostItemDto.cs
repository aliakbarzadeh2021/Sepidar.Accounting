using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PurchaseCostItemDto
    {
          
 
		public Int32 PurchaseCostItemID { get; set; }  
 
		public Int32 PurchaseCostRef { get; set; }  
 
		public Int32 PurchaseInvoiceItemRef { get; set; }  
 
		public Nullable<Int32> CommercialOrderItemRef { get; set; }  
 
		public Nullable<Int32> InsurancePolicyItemRef { get; set; }  
 
		public Decimal PurchaseInvoiceItemNetPriceInBaseCurrency { get; set; }  
 
		public Decimal TotalCommercialOrder { get; set; }  
 
		public Decimal TotalCommercialOrderInBaseCurrency { get; set; }  
 
		public Decimal TotalInsurancePolicy { get; set; }  
 
		public Decimal TotalInsurancePolicyInBaseCurrency { get; set; }  
 
		public Decimal TotalBillOfLoading { get; set; }  
 
		public Decimal TotalBillOfLoadingInBaseCurrency { get; set; }  
 
		public Decimal TotalCustomsClearance { get; set; }  
 
		public Decimal TotalCustomsClearanceInBaseCurrency { get; set; }  
 
		public Decimal TotalOtherCostsInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> AllotmenedAmountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> NetPriceInBaseCurrency { get; set; }  
 
		public Decimal FinalFeeInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


