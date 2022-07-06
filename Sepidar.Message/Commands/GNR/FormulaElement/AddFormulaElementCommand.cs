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
    public class AddFormulaElementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 FormulaElementID { get; set; }  
 
		public Int32 CalculationFormulaRef { get; set; }  
 
		public Int32 CalculationElementRef { get; set; } 

        public void Validate()
        {
            new AddFormulaElementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
