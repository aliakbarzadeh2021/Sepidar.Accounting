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
    public class EditCommissionCalculationXMLResultCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommissionCalculationXMLResultID { get; set; }  
 
		public Int32 CommissionCalculationRef { get; set; }  
 
		public String Content { get; set; } 

        public void Validate()
        {
            new EditCommissionCalculationXMLResultCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
