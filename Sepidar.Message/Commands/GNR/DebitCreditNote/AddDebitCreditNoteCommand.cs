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
    public class AddDebitCreditNoteCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DebitCreditNoteID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Decimal SumAmount { get; set; }  
 
		public Nullable<Decimal> SumAmountInBaseCurrency { get; set; } 

        public void Validate()
        {
            new AddDebitCreditNoteCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
