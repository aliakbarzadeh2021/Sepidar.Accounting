using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CostPart : BaseEntity
    {
          
 
		public Int32 CostPartId { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 CostPartType { get; set; }  
 
		public Decimal TotalCost { get; set; }  
 
		public Decimal AccumulatedDepreciation { get; set; }  
 
		public Decimal EstablishmentAccumulatedDepreciation { get; set; }  
 
		public DateTime EffectiveDate { get; set; }  
 
		public Decimal DepreciationRate { get; set; }  
 
		public Int32 DepreciationMethodType { get; set; }  
 
		public Decimal UsefulLife { get; set; }  
 
		public Decimal MaxDepreciableBookValue { get; set; }  
 
		public Decimal SalvageValue { get; set; }  
 
		public Nullable<Decimal> AcquisingElapsedLife { get; set; }  
 
		public Int32 DepreciationState { get; set; }  
 
		public Boolean IsInitial { get; set; } 
    }
}


