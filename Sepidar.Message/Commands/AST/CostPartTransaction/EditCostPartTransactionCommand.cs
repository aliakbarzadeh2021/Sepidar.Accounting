using Sepidar.Message.Base;
using Sepidar.Message.Extentions;
using Sepidar.Message.Validators;
using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class EditCostPartTransactionCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CostPartTransactionID { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; }  
 
		public Int32 CostPartRef { get; set; }  
 
		public Decimal TotalCost { get; set; }  
 
		public Int32 DepreciationMethodType { get; set; }  
 
		public Decimal UsefulLife { get; set; }  
 
		public Decimal MaxDepreciableBookValue { get; set; }  
 
		public Decimal DepreciationRate { get; set; }  
 
		public DateTime EffectiveDate { get; set; }  
 
		public Decimal AccumulatedDepreciation { get; set; }  
 
		public Decimal DepreciationValue { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Int32 Duration { get; set; }  
 
		public Nullable<DateTime> CalculationDate { get; set; }  
 
		public Int32 DepreciationState { get; set; }  
 
		public Decimal SalvageValue { get; set; }  
 
		public Nullable<Decimal> AcquisingElapsedLife { get; set; }  
 
		public Nullable<Decimal> AssetElapsedLife { get; set; }  
 
		public Decimal RemainingRoundingDepreciation { get; set; } 

        public void Validate()
        {
            new EditCostPartTransactionCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
