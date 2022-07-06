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
    public class AddContractCoefficientItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ContractCoefficientID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 CoefficientRef { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Single Percent { get; set; } 

        public void Validate()
        {
            new AddContractCoefficientItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
