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
    public class AddReturnedInvoiceCommissionBrokerCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReturnedInvoiceCommissionBrokerID { get; set; }  
 
		public Int32 ReturnedInvoiceRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Decimal SalePortionPercent { get; set; }  
 
		public Nullable<Decimal> ManualCommissionAmount { get; set; } 

        public void Validate()
        {
            new AddReturnedInvoiceCommissionBrokerCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
