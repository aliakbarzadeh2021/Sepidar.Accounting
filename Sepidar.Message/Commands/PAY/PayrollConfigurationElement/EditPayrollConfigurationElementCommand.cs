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
    public class EditPayrollConfigurationElementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayrollConfigurationElementId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Nullable<Decimal> Coefficient { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 PayrollConfigurationRef { get; set; } 

        public void Validate()
        {
            new EditPayrollConfigurationElementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
