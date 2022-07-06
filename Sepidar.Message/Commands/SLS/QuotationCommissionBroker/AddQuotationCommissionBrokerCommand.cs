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
    public class AddQuotationCommissionBrokerCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QuotationCommissionBrokerID { get; set; }  
 
		public Int32 QuotationRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Decimal SalePortionPercent { get; set; } 

        public void Validate()
        {
            new AddQuotationCommissionBrokerCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
