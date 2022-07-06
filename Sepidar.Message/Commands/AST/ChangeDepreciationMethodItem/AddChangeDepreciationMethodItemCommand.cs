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
    public class AddChangeDepreciationMethodItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ChangeDepreciationMethodItemId { get; set; }  
 
		public Int32 ChangeDepreciationMethodRef { get; set; }  
 
		public Int32 CostPartRef { get; set; }  
 
		public Int32 CostPartTransactionRef { get; set; }  
 
		public Int32 DepreciationMethodType { get; set; }  
 
		public Decimal DepreciationRate { get; set; }  
 
		public Decimal UsefulLife { get; set; }  
 
		public Decimal MaxDepreciableBookValue { get; set; }  
 
		public Decimal AssetElapsedLife { get; set; }  
 
		public Decimal AccumulatedDepreciation { get; set; }  
 
		public Decimal DepreciableBookValue { get; set; } 

        public void Validate()
        {
            new AddChangeDepreciationMethodItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
