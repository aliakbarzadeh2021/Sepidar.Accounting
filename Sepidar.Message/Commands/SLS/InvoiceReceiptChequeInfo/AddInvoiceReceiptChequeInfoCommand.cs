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
    public class AddInvoiceReceiptChequeInfoCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvoiceReceiptChequeInfoId { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public String Number { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String AccountNo { get; set; }  
 
		public Int32 BankRef { get; set; }  
 
		public Nullable<Int32> PartyAccountSettlementItemRef { get; set; } 

        public void Validate()
        {
            new AddInvoiceReceiptChequeInfoCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
