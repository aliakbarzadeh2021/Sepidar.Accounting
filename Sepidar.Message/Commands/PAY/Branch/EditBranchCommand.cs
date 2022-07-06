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
    public class EditBranchCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BranchId { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 BranchPartyRef { get; set; }  
 
		public String Code { get; set; }  
 
		public String ContractNumber { get; set; }  
 
		public Int32 NoInsurancePersonsCount { get; set; }  
 
		public Int32 AdjustmentType { get; set; }  
 
		public Nullable<Int32> CostCenterRef { get; set; }  
 
		public Nullable<Int32> CostCenterDlRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditBranchCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
