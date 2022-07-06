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
    public class EditReceiptChequeBankingItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReceiptChequeBankingItemId { get; set; }  
 
		public Int32 ReceiptChequeBankingRef { get; set; }  
 
		public Int32 ReceiptChequeRef { get; set; }  
 
		public Nullable<Int32> ReceiptChequeBankingItemRef { get; set; }  
 
		public Nullable<DateTime> ForcastDate { get; set; }  
 
		public Int32 State { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; }  
 
		public Nullable<Int32> CashRef { get; set; }  
 
		public Int32 HeaderState { get; set; } 

        public void Validate()
        {
            new EditReceiptChequeBankingItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
