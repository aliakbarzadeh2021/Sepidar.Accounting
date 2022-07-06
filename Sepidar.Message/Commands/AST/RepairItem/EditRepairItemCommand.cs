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
    public class EditRepairItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RepairItemId { get; set; }  
 
		public Int32 RepairRef { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 CostPartRef { get; set; }  
 
		public Int32 CostPartType { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; }  
 
		public Int32 DepreciationMethodType { get; set; }  
 
		public Decimal DepreciationRate { get; set; }  
 
		public Decimal UsefulLife { get; set; }  
 
		public Decimal MaxDepreciableBookValue { get; set; }  
 
		public Decimal SalvageValue { get; set; }  
 
		public Decimal TotalCost { get; set; }  
 
		public DateTime EffectiveDate { get; set; } 

        public void Validate()
        {
            new EditRepairItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
