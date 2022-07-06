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
    public class AddRefundChequeItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RefundChequeItemID { get; set; }  
 
		public Nullable<Int32> ReceiptChequeRef { get; set; }  
 
		public Nullable<Int32> PaymentChequeRef { get; set; }  
 
		public Nullable<Int32> RefundChequeRef { get; set; }  
 
		public Nullable<DateTime> HeaderDate { get; set; }  
 
		public Nullable<Int32> HeaderNumber { get; set; }  
 
		public Nullable<Int32> State { get; set; } 

        public void Validate()
        {
            new AddRefundChequeItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
