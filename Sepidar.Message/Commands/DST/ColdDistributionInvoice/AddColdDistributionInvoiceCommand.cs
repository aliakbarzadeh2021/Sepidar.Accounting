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
    public class AddColdDistributionInvoiceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ColdDistributionInvoiceId { get; set; }  
 
		public Int32 ColdDistributionRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public Nullable<Int32> UnexecutedActReasonRef { get; set; } 

        public void Validate()
        {
            new AddColdDistributionInvoiceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
