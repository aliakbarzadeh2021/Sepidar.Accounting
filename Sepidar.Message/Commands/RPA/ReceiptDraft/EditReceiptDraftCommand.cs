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
    public class EditReceiptDraftCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReceiptDraftId { get; set; }  
 
		public String Number { get; set; }  
 
		public Nullable<DateTime> Date { get; set; }  
 
		public Nullable<Decimal> Amount { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 ReceiptHeaderRef { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; } 

        public void Validate()
        {
            new EditReceiptDraftCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
