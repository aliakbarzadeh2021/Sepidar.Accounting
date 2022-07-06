using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PurchaseOrderDto
    {
          
 
		public Int32 PurchaseOrderID { get; set; }  
 
		public Int32 VendorDLRef { get; set; }  
 
		public Int32 PerformaRef { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal CurrencyRate { get; set; }  
 
		public Nullable<Decimal> TotalPrice { get; set; }  
 
		public Nullable<Decimal> TotalPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalNetPrice { get; set; }  
 
		public Nullable<Decimal> TotalNetPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalDiscount { get; set; }  
 
		public Nullable<Decimal> TotalDiscountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalAddition { get; set; }  
 
		public Nullable<Decimal> TotalAdditionInBaseCurrency { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Int32 State { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


