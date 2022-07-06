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
    public class AddSalesLimitItemPartyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SalesLimitItemPartyId { get; set; }  
 
		public Int32 SalesLimitItemRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Nullable<Decimal> Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; } 

        public void Validate()
        {
            new AddSalesLimitItemPartyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
