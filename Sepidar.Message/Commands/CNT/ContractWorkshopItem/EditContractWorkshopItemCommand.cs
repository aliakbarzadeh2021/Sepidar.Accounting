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
    public class EditContractWorkshopItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ContractWorkshopItemID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 WorkshopRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 

        public void Validate()
        {
            new EditContractWorkshopItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
