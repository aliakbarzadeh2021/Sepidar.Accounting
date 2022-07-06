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
    public class AddCommissionCalculationInvoiceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommissionCalculationInvoiceID { get; set; }  
 
		public Int32 CommissionCalculationRef { get; set; }  
 
		public Nullable<Int32> InvoiceItemRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceItemRef { get; set; } 

        public void Validate()
        {
            new AddCommissionCalculationInvoiceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
