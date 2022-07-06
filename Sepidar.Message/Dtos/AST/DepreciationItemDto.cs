using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class DepreciationItemDto
    {
          
 
		public Int32 DepreciationItemID { get; set; }  
 
		public Int32 DepreciationRef { get; set; }  
 
		public Int32 CostPartRef { get; set; }  
 
		public Int32 CostPartTransactionRef { get; set; }  
 
		public Int32 LastCostPartTransactionRef { get; set; }  
 
		public Nullable<DateTime> CalculationDate { get; set; }  
 
		public Decimal DepreciationValue { get; set; }  
 
		public Int32 Duration { get; set; }  
 
		public Decimal AccumulatedDepreciation { get; set; }  
 
		public Int32 DepreciationState { get; set; }  
 
		public Nullable<Decimal> AssetElapsedLife { get; set; }  
 
		public Decimal RemainingRoundingDepreciation { get; set; }  
 
		public Decimal pDepreciationRate { get; set; }  
 
		public Decimal pUsefulLife { get; set; }  
 
		public Decimal pRemainingBookValue { get; set; } 
    }
}


