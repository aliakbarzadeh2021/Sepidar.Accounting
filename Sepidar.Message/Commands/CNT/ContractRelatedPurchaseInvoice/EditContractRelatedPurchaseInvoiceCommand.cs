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
    public class EditContractRelatedPurchaseInvoiceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ContractRelatedPurchaseInvoiceId { get; set; }  
 
		public Int32 PurchaseInvoiceRef { get; set; }  
 
		public Int32 TenderRef { get; set; } 

        public void Validate()
        {
            new EditContractRelatedPurchaseInvoiceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
