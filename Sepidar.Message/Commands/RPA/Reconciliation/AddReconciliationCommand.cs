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
    public class AddReconciliationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReconciliationId { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Int32 BankAccountRef { get; set; }  
 
		public Nullable<Int32> BankBillRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Decimal BankBalance { get; set; }  
 
		public Decimal BankBillBalance { get; set; }  
 
		public Nullable<Decimal> BankBalanceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> BankBillBalanceInBaseCurrency { get; set; } 

        public void Validate()
        {
            new AddReconciliationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
