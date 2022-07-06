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
    public class AddReceiptChequeBankingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReceiptChequeBankingId { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> RelationNo { get; set; }  
 
		public Nullable<Int32> BankAccountRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> ReceiptChequeBankingRef { get; set; }  
 
		public Nullable<Int32> CashRef { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public String SubmitNumber { get; set; } 

        public void Validate()
        {
            new AddReceiptChequeBankingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
