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
    public class EditPartyAccountSettlementItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PartyAccountSettlementItemID { get; set; }  
 
		public Int32 PartyAccountSettlementRef { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<Int32> DebitEntityType { get; set; }  
 
		public Nullable<Int32> DebitEntityRef { get; set; }  
 
		public Nullable<Int32> CreditEntityType { get; set; }  
 
		public Nullable<Int32> CreditEntityRef { get; set; }  
 
		public Boolean IsSettled { get; set; }  
 
		public Nullable<Int32> OldPartySettlementItemID { get; set; }  
 
		public Nullable<Int32> OldPartySettlementID { get; set; } 

        public void Validate()
        {
            new EditPartyAccountSettlementItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
