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
    public class EditInvoiceReceiptInfoCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvoiceReceiptInfoID { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public Decimal Discount { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Decimal PosAmount { get; set; }  
 
		public Decimal DraftAmount { get; set; }  
 
		public Nullable<Int32> PartyAccountSettlementItemRef { get; set; } 

        public void Validate()
        {
            new EditInvoiceReceiptInfoCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
