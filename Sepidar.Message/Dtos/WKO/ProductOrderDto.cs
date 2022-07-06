using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ProductOrderDto
    {
          
 
		public Int32 ProductOrderID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> BaseProductOrderRef { get; set; }  
 
		public Int32 CostCenterRef { get; set; }  
 
		public Int32 ProductRef { get; set; }  
 
		public Int32 ProductFormulaRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> WastageQuantity { get; set; }  
 
		public Nullable<Int32> CustomerPartyRef { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Nullable<Decimal> RemainingBOMCost { get; set; }  
 
		public Nullable<Decimal> BOMCost { get; set; }  
 
		public Nullable<Decimal> EstimatedLabourCost { get; set; }  
 
		public Nullable<Decimal> EstimatedOverheadCost { get; set; }  
 
		public Nullable<Decimal> Cost { get; set; }  
 
		public Nullable<Decimal> BOMPercent { get; set; }  
 
		public Nullable<Decimal> EstimatedLabourPercent { get; set; }  
 
		public Nullable<Decimal> EstimatedOverheadPercent { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Boolean CanTransferNextPeriod { get; set; }  
 
		public Boolean IsInitial { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}


