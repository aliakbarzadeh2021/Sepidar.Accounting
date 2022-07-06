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
    public class AddReturnedInvoiceBrokerCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReturnedInvoiceBrokerID { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Decimal Commission { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal CommissionInBaseCurrency { get; set; }  
 
		public Int32 PartyRef { get; set; } 

        public void Validate()
        {
            new AddReturnedInvoiceBrokerCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
