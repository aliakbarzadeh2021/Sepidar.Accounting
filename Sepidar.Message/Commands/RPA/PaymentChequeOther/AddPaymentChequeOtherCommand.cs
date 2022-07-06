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
    public class AddPaymentChequeOtherCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PaymentChequeOtherId { get; set; }  
 
		public Int32 ReceiptChequeRef { get; set; }  
 
		public Int32 PaymentHeaderRef { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public DateTime HeaderDate { get; set; } 

        public void Validate()
        {
            new AddPaymentChequeOtherCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
