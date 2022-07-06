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
    public class EditElementSavedValueCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ElementSavedValueID { get; set; }  
 
		public Int32 CalculationFormulaRef { get; set; }  
 
		public String Key { get; set; }  
 
		public String Values { get; set; } 

        public void Validate()
        {
            new EditElementSavedValueCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
