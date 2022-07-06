using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ItemDto
    {
          
 
		public Int32 ItemID { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public String BarCode { get; set; }  
 
		public Nullable<Int32> UnitRef { get; set; }  
 
		public Nullable<Int32> SecondaryUnitRef { get; set; }  
 
		public Nullable<Int32> SaleUnitRef { get; set; }  
 
		public Boolean IsUnitRatioConstant { get; set; }  
 
		public Nullable<Double> UnitsRatio { get; set; }  
 
		public Nullable<Double> MinimumAmount { get; set; }  
 
		public Nullable<Double> MaximumAmount { get; set; }  
 
		public Boolean CanHaveTracing { get; set; }  
 
		public Nullable<Int32> TracingCategoryRef { get; set; }  
 
		public Boolean IsPricingBasedOnTracing { get; set; }  
 
		public Boolean TaxExempt { get; set; }  
 
		public Boolean TaxExemptPurchase { get; set; }  
 
		public Boolean Sellable { get; set; }  
 
		public Nullable<Int32> DefaultStockRef { get; set; }  
 
		public Nullable<Int32> PurchaseGroupRef { get; set; }  
 
		public Nullable<Int32> SaleGroupRef { get; set; }  
 
		public Nullable<Int32> CompoundBarcodeRef { get; set; }  
 
		public Nullable<Int32> ItemCategoryRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Nullable<Int32> AccountSLRef { get; set; }  
 
		public Decimal TaxRate { get; set; }  
 
		public Decimal DutyRate { get; set; }  
 
		public Nullable<Int32> CodingGroupRef { get; set; }  
 
		public Boolean SerialTracking { get; set; }  
 
		public Nullable<Decimal> Weight { get; set; }  
 
		public Nullable<Decimal> Volume { get; set; }  
 
		public String IranCode { get; set; } 
    }
}


