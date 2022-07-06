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
    public class EditInvoiceCommissionBrokerCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvoiceCommissionBrokerID { get; set; }  
 
		public Int32 InvoiceRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Decimal SalePortionPercent { get; set; }  
 
		public Nullable<Decimal> ManualCommissionAmount { get; set; } 

        public void Validate()
        {
            new EditInvoiceCommissionBrokerCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
