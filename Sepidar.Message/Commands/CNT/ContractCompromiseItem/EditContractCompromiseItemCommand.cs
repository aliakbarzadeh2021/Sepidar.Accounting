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
    public class EditContractCompromiseItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ContractCompromiseItemID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 

        public void Validate()
        {
            new EditContractCompromiseItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
