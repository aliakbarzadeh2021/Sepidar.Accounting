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
    public class AddDebitCreditNoteItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DebitCreditNoteItemID { get; set; }  
 
		public Int32 DebitCreditNoteRef { get; set; }  
 
		public Int32 RowID { get; set; }  
 
		public Int32 DebitSLRef { get; set; }  
 
		public Int32 CreditSLRef { get; set; }  
 
		public Nullable<Int32> DebitDLRef { get; set; }  
 
		public Nullable<Int32> CreditDLRef { get; set; }  
 
		public Nullable<Int32> DebitType { get; set; }  
 
		public Nullable<Int32> CreditType { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<Decimal> Rate { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddDebitCreditNoteItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
