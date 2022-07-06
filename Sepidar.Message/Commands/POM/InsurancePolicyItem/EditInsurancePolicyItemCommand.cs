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
    public class EditInsurancePolicyItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InsurancePolicyItemID { get; set; }  
 
		public Int32 InsurancePolicyRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 BasePurchaseOrderItemRef { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Nullable<Decimal> PriceInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditInsurancePolicyItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
