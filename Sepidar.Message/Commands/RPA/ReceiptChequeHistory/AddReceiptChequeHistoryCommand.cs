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
    public class AddReceiptChequeHistoryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReceiptChequeHistoryId { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> ReceiptChequeHistoryRef { get; set; }  
 
		public Int32 ReceiptChequeRef { get; set; }  
 
		public Nullable<Int32> ReceiptChequeBankingItemRef { get; set; }  
 
		public Nullable<Int32> PaymentChequeOtherRef { get; set; }  
 
		public Nullable<Int32> RefundChequeItemRef { get; set; } 

        public void Validate()
        {
            new AddReceiptChequeHistoryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
