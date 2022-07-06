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
    public class EditColdDistributionReturnedInvoiceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ColdDistributionReturnedInvoiceId { get; set; }  
 
		public Int32 ColdDistributionRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Nullable<Int32> UnexecutedActReasonRef { get; set; } 

        public void Validate()
        {
            new EditColdDistributionReturnedInvoiceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
