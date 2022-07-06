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
    public class EditReconciliationBankItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReconciliationBankItemId { get; set; }  
 
		public Nullable<Int32> BankBillItemRef { get; set; }  
 
		public Nullable<Int32> RelationNo { get; set; }  
 
		public String Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Decimal Debit { get; set; }  
 
		public Decimal Credit { get; set; }  
 
		public Int32 ReconciliationRef { get; set; }  
 
		public Nullable<Int32> ReconciliationBankItemRef { get; set; } 

        public void Validate()
        {
            new EditReconciliationBankItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
