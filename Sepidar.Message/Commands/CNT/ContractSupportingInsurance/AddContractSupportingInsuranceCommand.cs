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
    public class AddContractSupportingInsuranceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ContractSupportingInsuranceID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 BranchCode { get; set; }  
 
		public String BranchTitle { get; set; }  
 
		public String BranchTitle_En { get; set; }  
 
		public String WorkshopCode { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 

        public void Validate()
        {
            new AddContractSupportingInsuranceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
