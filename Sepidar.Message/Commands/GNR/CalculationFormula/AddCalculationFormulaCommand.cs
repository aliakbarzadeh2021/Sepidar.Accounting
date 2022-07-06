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
    public class AddCalculationFormulaCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CalculationFormulaID { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public String Text { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddCalculationFormulaCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
